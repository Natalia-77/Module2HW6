using Module2HW6.Model;

namespace Module2HW6.Service.Abstractions
{
    public interface IApplianceService
    {
        public double FullPower();
        public void SortByPower();
        public Appliance[] GetAllAppliances();
        public void TurnOnSocket(Appliance item);
    }
}
