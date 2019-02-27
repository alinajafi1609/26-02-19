using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electrical_Circuit_Simulator
{
    public class ComponentElectromagnets
    {
        public ComponentElectromagnets(double MagneticFluxDensity, double Length, string name, int Junction, double Resistance)
        {
            B = MagneticFluxDensity;
            L = Length;
            J = Junction;
            N = name;
            R = Resistance;
        }
        public double B { get; set; }
        public double L { get; set; }
        public string N { get; set; }
        public int J { get; set; }
        public double R { get; set; }
    }
}
