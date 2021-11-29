using Module2HW6.Enum;

namespace Module2HW6.Model.PortableAppliances
{
    public class FloorCleaner : CleanAppliances
    {
        public FloorCleaner()
        {
            Producer = Enum.Company.Samsung;
        }

        public FloorCleanerType FloorCleanerType { get; set; }
    }
}
