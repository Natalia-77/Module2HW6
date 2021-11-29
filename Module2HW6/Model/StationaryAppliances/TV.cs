using Module2HW6.Enum;

namespace Module2HW6.Model.StationaryAppliances
{
    public class TV : EntertainmentAppliances
    {
        public TV()
        {
            Producer = Enum.Company.Panasonic;
        }

        public TVType TVType { get; set; }
    }
}
