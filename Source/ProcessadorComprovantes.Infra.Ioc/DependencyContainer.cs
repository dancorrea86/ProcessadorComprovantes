using ProcessadorComprovantes.Application.Interfaces;
using ProcessadorComprovantes.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace ProcessadorComprovantes.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
        }
    }
}
