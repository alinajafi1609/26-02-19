using System.Collections.Generic;

namespace Electrical_Circuit_Simulator
{
    public class Circuit
    {
        public List<ComponentResistors> ComponentResistorList { get; }
        public List<ComponentPowerSource> ComponentPowerSourceList { get; }
        public Circuit()
        {
            ComponentResistorList = new List<ComponentResistors>();
            ComponentPowerSourceList = new List<ComponentPowerSource>();
        }

        public double caclucate()

        {


            return 0;
        }
    }
}
