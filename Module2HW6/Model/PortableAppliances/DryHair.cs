using Module2HW6.Enum;

namespace Module2HW6.Model.PortableAppliances
{
    public class DryHair : DryAppliances
    {
        public DryHair()
        {
            Producer = Enum.Company.Philips;
        }

        public DryType DryType { get; set; }
    }
}
