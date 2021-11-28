namespace Module2HW6.Model.StationaryAppliances
{
    public abstract class FreezeAppliances : Stationary
    {
        public FreezeAppliances()
        {
            Work = Enum.WorkType.Freeze;
        }
    }
}
