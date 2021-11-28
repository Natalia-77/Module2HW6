using Module2HW6.Enum;

namespace Module2HW6.Model.StationaryAppliances
{
    public abstract class Stationary : Appliance
    {
        public Stationary()
        {
            StateType = State.Station;
        }
    }
}
