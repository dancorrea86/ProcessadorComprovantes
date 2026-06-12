using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessadorComprovantes.Application.Interfaces
{
    public interface IFileService
    {
        void MoveFile(string sourcePath, string destinationPath);
    }
}
