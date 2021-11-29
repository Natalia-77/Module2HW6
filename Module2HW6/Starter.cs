using System;
using Module2HW6.Provider;
using Module2HW6.Service.Abstractions;

namespace Module2HW6
{
   public class Starter
    {
        private readonly IApplianceService _applianceService;
        private readonly ApplianceProvider _appliencesProvider;
        private readonly IConfigService _configService;
        private readonly double _capacity;
        public Starter(
            IApplianceService applianceService,
            IConfigService configService,
            ApplianceProvider appliancesProvider)
        {
            _configService = configService;
            _capacity = configService.GetConfig().MaxCapacity;
            _applianceService = applianceService;
            _appliencesProvider = appliancesProvider;
        }

        public void Run()
        {
            var rnd = new Random();
            for (var i = 0; i < _capacity; i++)
            {
                var num = rnd.Next(0, _appliencesProvider.Appliances.Length);
                _applianceService.TurnOnSocket(_appliencesProvider.Appliances[num]);
            }

            var power = _applianceService.FullPower();
            var all = _applianceService.GetAllAppliances();
            foreach (var item in all)
            {
                Console.WriteLine(item.Power);
            }
        }
   }
}
