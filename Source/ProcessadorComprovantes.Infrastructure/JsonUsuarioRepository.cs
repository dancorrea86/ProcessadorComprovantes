using ProcessadorComprovantes.Domain.Entities;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProcessadorComprovantes.Infrastructure;

public class JsonUsuarioRepository : Application.Interfaces.IUserRepository
{
    //public void SaveUser(Usuario usuario)
    //{

    //    var json = System.Text.Json.JsonSerializer.Serialize(usuario);

    //    // Salvar o JSON em um arquivo (exemplo: "usuarios.json")


    //    // Retorna o caminho para a pasta Roaming
    //    string roamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

    //    // Retorna o caminho para a pasta Local
    //    string localPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

    //    var diretorio = Path.Combine(localPath, "ProcessadorComprovantes");

    //    if (Path.Exists(diretorio) == false)
    //    {
    //        Directory.CreateDirectory(diretorio);
    //    }

    //    string path = Path.Combine(localPath, "ProcessadorComprovantes", "User.json");

    //    if (File.Exists(path))
    //    {
    //        System.IO.File.AppendAllText(path, json);
    //    }
    //    else
    //    {
    //        File.WriteAllText(path, json);
    //    }
    //}

    public void SaveUser(Usuario usuario)
    {
        string localPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string diretorio = Path.Combine(localPath, "ProcessadorComprovantes");
        string path = Path.Combine(diretorio, "User.json");

        if (!Directory.Exists(diretorio))
        {
            Directory.CreateDirectory(diretorio);
        }

        // 1. Busca a lista atual de usuários
        List<Usuario> listaCompleta = GetUsers();

        // 2. Adiciona o novo usuário à lista
        listaCompleta.Add(usuario);

        // 3. Serializa a lista INTEIRA (com o novo usuário incluso)
        // O 'WriteIndented = true' deixa o arquivo .json legível para humanos
        var options = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
        var json = System.Text.Json.JsonSerializer.Serialize(listaCompleta, options);

        // 4. Salva no arquivo (sobrescrevendo o anterior com a nova lista atualizada)
        File.WriteAllText(path, json);
    }

    public List<Usuario> GetUsers()
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProcessadorComprovantes", "User.json");

        if (!File.Exists(path))
        {
            return new List<Usuario>();
        }

        try
        {
            string json = File.ReadAllText(path);
            return System.Text.Json.JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
        }
        catch (Exception)
        {
            return new List<Usuario>();
        }
    }
}
