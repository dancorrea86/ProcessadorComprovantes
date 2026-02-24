namespace ProcessadorComprovantes.Domain.Entities;

public class Usuario
{
    public string Nome { get; set; } = "";
    public string DiretorioRaiz { get; set; } = "";

    public Usuario(string nome, string diretorioRaiz)
    {
        Nome = nome;
        DiretorioRaiz = diretorioRaiz;
    }
}
