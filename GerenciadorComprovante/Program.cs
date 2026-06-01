using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProcessadorComprovantes.Application.Interfaces;
using ProcessadorComprovantes.Infrastructure;

namespace GerenciadorComprovante
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            HostApplicationBuilder builder = Host.CreateApplicationBuilder();

            
            
            builder.Services.AddSingleton<IFileService, FileService>();

            IHost host = builder.Build();

            host.Start();

            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal(host.Services.GetRequiredService<IFileService>()));
        }
    }
}