namespace Electrical_Circuit_Simulator
{
    public class ComponentPowerSource
    {
        public ComponentPowerSource(double Volt, double InternalResistance, string name)
        {
            Volts = Volt;
            IR = InternalResistance;
            name = Name;

        }
        public double IR { get; set; }
        public double Volts { get; set; }
        public string Name { get; set; }
    }
}
