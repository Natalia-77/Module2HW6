using Module2HW6.Enum;

namespace Module2HW6.Model.StationaryAppliances
{
    public class Refregerator : FreezeAppliances
    {
        public Refregerator()
        {
            Producer = Enum.Company.Gorenie;
        }

        public RefregeratorType RefregeratorType { get; set; }
    }
}
