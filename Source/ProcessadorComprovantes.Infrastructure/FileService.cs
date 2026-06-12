using ProcessadorComprovantes.Application.Interfaces;

namespace ProcessadorComprovantes.Infrastructure
{
    public class FileService : IFileService
    {
        public void MoveFile(string sourcePath, string destinationPath)
        {
            if (File.Exists(sourcePath))
            {
                File.Move(sourcePath, destinationPath);
            }
        }
    }
}
