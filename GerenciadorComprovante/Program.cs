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

            var form = host.Services.GetRequiredService<FormPrincipal>();

            Application.Run(form);
        }

        public static void RegisterServices(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
        }
    }
}