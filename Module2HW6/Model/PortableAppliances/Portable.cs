namespace Module2HW6.Model.PortableAppliances
{
    public abstract class Portable : Appliance
    {
        public Portable()
        {
            StateType = Enum.State.Portable;
        }
    }
}
