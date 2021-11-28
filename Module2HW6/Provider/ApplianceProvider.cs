﻿using Module2HW6.Model;
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
                     Price = 15999, Power = 2000
                },
                new TV()
                {
                    Price = 21500, Power = 500
                },
                new DryHair()
                {
                    Price = 900, Power = 400
                },
                new FloorCleaner()
                {
                    Price = 9200, Power = 1500
                }
            };
        }

        public Appliance[] Appliances { get; }
    }
}
