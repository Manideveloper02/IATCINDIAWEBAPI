using IATCINDIA.DATA.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace IATCINDIA.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IatcUserRepository>();
        }

    }

}
