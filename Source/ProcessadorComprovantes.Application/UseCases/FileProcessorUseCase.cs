using ProcessadorComprovantes.Application.Interfaces;

namespace ProcessadorComprovantes.Application.UseCases
{
    public class FileProcessorUseCase
    {
        private readonly IFileService _fileService;

        public FileProcessorUseCase(IFileService fileService)
        {
            _fileService = fileService;
        }

        public void Executar(string file, string sourcePath, string destinationPath)
        {
            CriarPastaSeNaoExistir(file, destinationPath);
            _fileService.MoveFile(sourcePath, destinationPath);
        }

        private void CriarPastaSeNaoExistir(string file, string destinationPath)
        {
            string ano = file.Substring(0, 4);
            string anoMes = file.Substring(0, 7);
            string caminhoFinal = Path.Combine(destinationPath, ano, anoMes);

            if (!Directory.Exists(caminhoFinal))
            {
                Directory.CreateDirectory(caminhoFinal);
            }
        }
    }
}
