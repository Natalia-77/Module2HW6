using Module2HW6.Enum;
using Module2HW6.Model;
using Module2HW6.Model.PortableAppliances;
using Module2HW6.Model.StationaryAppliances;
using Module2HW6.Provider.Abstactions;

namespace Module2HW6.Provider
{
    public class ApplianceProvider : IApplianceProvider
    {
        public ApplianceProvider()
        {
            Appliances = new Appliance[]
            {
                new Refregerator()
                {
                    Name = "Холодильник",
                    RefregeratorType = RefregeratorType.Large,
                    Price = 15999,
                    Power = 2000
                },
                new TV()
                {
                    Name = "Телевизор",
                    TVType = TVType.Large,
                    Price = 21500,
                    Power = 500
                },
                new DryHair()
                {
                  Name = "ФЕН",
                  DryType = DryType.Professional,
                  Price = 900,
                  Power = 400
                },
                new FloorCleaner()
                {
                  Name = "Пылесос ",
                  FloorCleanerType = FloorCleanerType.Home,
                  Price = 9200,
                  Power = 1500
                },
                new Refregerator()
                {
                    Name = "Холодильник",
                    RefregeratorType = RefregeratorType.Large,
                    Price = 20000,
                    Power = 3000
                },
            };
        }

        public Appliance[] Appliances { get; }
    }
}
