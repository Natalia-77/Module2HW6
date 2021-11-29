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
                    Name = "Холодильник Gorenie RB34T600FSA/UA ",
                    RefregeratorType = RefregeratorType.Large,
                    Price = 15999,
                    Power = 2000
                },
                new TV()
                {
                    Name = "Телевизор Panasonic QE55Q60AAUXUA ",
                    TVType = TVType.Large,
                    Price = 21500,
                    Power = 500
                },
                new DryHair()
                {
                  Name = "ФЕН DYSON SUPERSONIC HD01 ",
                  DryType = DryType.Professional,
                  Price = 900,
                  Power = 400
                },
                new FloorCleaner()
                {
                  Name = "Аккумуляторный пылесос BCS612KA2 ",
                  FloorCleanerType = FloorCleanerType.Home,
                  Price = 9200,
                  Power = 1500
                }
            };
        }

        public Appliance[] Appliances { get; }
    }
}
