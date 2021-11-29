using Module2HW6.Enum;

namespace Module2HW6.Model
{
    public abstract class Appliance
    {
        public Company Producer { get; set; }
        public ComplexType Complex { get; set; }
        public State StateType { get; set; }
        public WorkType Work { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Power { get; set; }
    }
}
