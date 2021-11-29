using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Provider;
using Module2HW6.Service;
using Module2HW6.Service.Abstractions;
namespace Module2HW6
{
   public class Application
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IConfigService, ConfigService>()
                .AddTransient<IApplianceService, ApplianceService>()
                .AddTransient<ApplianceProvider>()
                .AddTransient<Starter>().BuildServiceProvider();

            serviceProvider.GetService<Starter>().Run();
        }
    }
}
