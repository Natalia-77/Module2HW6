using Module2HW6.Exceptions;
using Module2HW6.Model;

namespace Module2HW6.Service.Abstractions
{
    public class ApplianceService : IApplianceService
    {
        private readonly IConfigService _configService;
        private readonly int _capacity;
        private Appliance[] _appliances;
        public ApplianceService(IConfigService configService)
        {
            _configService = configService;
            _capacity = configService.GetConfig().MaxCapacity;
            _appliances = new Appliance[_capacity];
        }

        public void TurnOnSocket(Appliance item)
        {
            try
            {
                for (var i = 0; i < _capacity; i++)
                {
                    if (_appliances[i] == null)
                    {
                        _appliances[i] = item;
                        return;
                    }
                }
            }
            catch (ServiceException)
            {
                throw new ServiceException("No free place anymore");
            }
        }

        public double FullPower()
        {
            var sum = 0d;
            foreach (var item in _appliances)
            {
                if (item != null)
                {
                    sum += item.Power;
                }
            }

            return sum;
        }

        public Appliance[] GetAllAppliances()
        {
            return _appliances;
        }

        public void SortByPower()
        {
            throw new System.NotImplementedException();
        }
    }
}
