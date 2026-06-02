using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProcessadorComprovantes.Application.Interfaces;
using ProcessadorComprovantes.Infra.Ioc;

namespace GerenciadorComprovante
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            HostApplicationBuilder builder = Host.CreateApplicationBuilder();

            RegisterServices(builder.Services);

            builder.Services.AddTransient<FormPrincipal>();
            IHost host = builder.Build();

            host.Start();

            // 2. CORREÇÃO: Deixe o host criar o formulário para você.
            // O .NET vai olhar o construtor do FormPrincipal, ver que ele precisa de um IFileService,
            // vai buscar o FileService no container e injetar tudo automaticamente.
            var form = host.Services.GetRequiredService<FormPrincipal>();

            Application.Run(form);
        }

        public static void RegisterServices(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
        }
    }
}