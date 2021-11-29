using System.Collections;
using Module2HW6.Model;

namespace Module2HW6.Helper
{
    public class PowerComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var first = (x as Appliance)?.Power;
            var second = (y as Appliance)?.Power;

            if (first > second)
            {
                return 1;
            }
            else if (first < second)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
