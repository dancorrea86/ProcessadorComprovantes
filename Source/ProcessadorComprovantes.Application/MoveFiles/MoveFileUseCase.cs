using ProcessadorComprovantes.Domain.Entities;

namespace ProcessadorComprovantes.Application.MoveFiles
{
    public class MoveFileUseCase
    {
        public static void Renomear(string arquivo)
        {
            try
            {
                Comprovante comprovante = new Comprovante(arquivo);

                
                if (!File.Exists(comprovante.CaminhoCompleto))
                {
                    throw new FileNotFoundException("O arquivo especificado não foi encontrado.", comprovante.DiretorioOriginal);
                };

                File.Move(
                    Path.Combine(comprovante.CaminhoCompleto),
                    Path.Combine(comprovante.DiretorioOriginal, comprovante.NomeComData)
                );

                Console.WriteLine($"Arquivo renomeado.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao renomear o arquivo: {e.Message}");
            }
        }
    }
}
