using System;

namespace ProcessadorComprovantes.Domain.Entities
{
    public class Comprovante
    {
        public DateTime Data { get; set; }
        public string CaminhoCompleto { get; set; } = "";
        public string Nome { get; set; } = "";
        public string NomeComData { get; set; } = "";
        public string DiretorioOriginal { get; set; } = "";
        public string DiretorioDestino { get; set; } = "";
        public string Usuario { get; set; } = "";

        public Comprovante(string caminhoArquivo)
        {
            Data = DateTime.Now;
            CaminhoCompleto = caminhoArquivo;
            Nome = $"{Path.GetFileName(caminhoArquivo)}";
            NomeComData = $"{Data:yyyyMMdd}_{Path.GetFileName(caminhoArquivo)}";
            DiretorioOriginal = Path.GetDirectoryName(caminhoArquivo) ?? "";
            DiretorioDestino = "";

        }
    }
}
