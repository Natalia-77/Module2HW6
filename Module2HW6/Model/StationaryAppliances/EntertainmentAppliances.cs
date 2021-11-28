namespace Module2HW6.Model.StationaryAppliances
{
   public abstract class EntertainmentAppliances : Stationary
    {
        public EntertainmentAppliances()
        {
            Work = Enum.WorkType.Entertainment;
        }
    }
}
