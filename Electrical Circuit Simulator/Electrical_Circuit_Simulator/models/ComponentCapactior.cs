using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electrical_Circuit_Simulator
{
    public class ComponentCapacitor
    {
        public ComponentCapacitor(double Capacitance, double Resistance, string name, int Junction, double Charge)
        {
            Ca = Capacitance;
            Ch = Charge;
            J = Junction;
            N = name;
            R = Resistance;
        }
        public double Ca { get; set; }
        public double Ch { get; set; }
        public string N { get; set; }
        public int J { get; set; }
        public double R { get; set; }
    }
}
