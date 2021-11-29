using Module2HW6.Enum;
using Module2HW6.Model;

namespace Module2HW6.Helper
{
   public static class ExtentionAppliance
    {
        public static Appliance[] SearchByCompany(this Appliance[] appliances, Company producer)
        {
            var count = 0;

            foreach (var item in appliances)
            {
                if (item != null && item.Producer == producer)
                {
                    count++;
                }
            }

            var result = new Appliance[count];
            var index = 0;

            foreach (var item in appliances)
            {
                if (item != null && item.Producer == producer)
                {
                    result[index++] = item;
                }
            }

            return result;
        }
    }
}
