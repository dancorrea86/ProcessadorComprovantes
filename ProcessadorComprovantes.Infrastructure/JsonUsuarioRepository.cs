using ProcessadorComprovantes.Domain.Entities;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProcessadorComprovantes.Infrastructure;

public class JsonUsuarioRepository : Application.Interfaces.IUserRepository
{
    public void SaveUser(Usuario usuario)
    {
        
        var json = System.Text.Json.JsonSerializer.Serialize(usuario);
        
        // Salvar o JSON em um arquivo (exemplo: "usuarios.json")
        

        // Retorna o caminho para a pasta Roaming
        string roamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        // Retorna o caminho para a pasta Local
        string localPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        
        var diretorio = Path.Combine(localPath, "ProcessadorComprovantes");

        if (Path.Exists(diretorio) == false)
        {
            Directory.CreateDirectory(diretorio);
        }

        string path = Path.Combine(localPath, "ProcessadorComprovantes", "User.json");

        if (File.Exists(path))
        {
            System.IO.File.AppendAllText(path, json);
        }
        else
        { 
            File.WriteAllText(path, json);
        }
        
    }
}
