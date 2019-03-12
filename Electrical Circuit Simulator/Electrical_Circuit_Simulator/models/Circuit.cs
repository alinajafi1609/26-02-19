using System;
using System.Collections.Generic;
using System.Linq;

namespace Electrical_Circuit_Simulator
{
    public class Circuit
    {
        public List<ComponentResistors> ComponentResistorList { get; }
        public List<ComponentPowerSource> ComponentPowerSourceList { get; }
        public List<ComponentElectromagnets> ComponentElectromagnetsList { get; }
        double Junction;
        double ResistanceOfEachComponent;
        double ResistanceofJunction;
        double OneDividedTotalResistance;
        double TotalResistance;
        double TotalResistanceofJunction;
        double CurrentofEachJunction;
        double VoltageofEachComponent;
        double Power;
        double EMF;
        double Force;
        double MagneticFluxDensity;
        double Length;
        double SinDirection;
        double Direction;
        public Circuit()
        {
            ComponentResistorList = new List<ComponentResistors>();
            ComponentPowerSourceList = new List<ComponentPowerSource>();
            ComponentElectromagnetsList = new List<ComponentElectromagnets>();
            
        }

        public double calculate()

        {
            //Power of EachComponent = The voltage of each Compoent squared / R Repeat this for each object
            Power = (VoltageofEachComponent * VoltageofEachComponent) / ResistanceOfEachComponent;
            //If a component in a list has the same junction add up the resistances of each component else just asign the resistance of each component to a the total resistance of the junction.
            foreach (var Component in ComponentResistorList)
                //{

                //      }
                if (Junction == Junction)
                {
                    TotalResistanceofJunction = ResistanceOfEachComponent + ResistanceOfEachComponent;

                }
                else
                {
                    TotalResistanceofJunction = ResistanceOfEachComponent;
                }

            // Store each of the vakyes of the total resistance in a list.
            // Add up 1/TotalResistanceofEachJunction for as many junction there are.
            OneDividedTotalResistance = 1/TotalResistanceofJunction + 1/TotalResistanceofJunction;
            //The total resitance = 1/OneDividedTotalResistance
            TotalResistance = 1 / OneDividedTotalResistance;
            //Current of EachJunction = EMF/Totoal ResistanceoftheJunction
            CurrentofEachJunction = EMF/TotalResistance;
            //Current of the Junction they are stationed in multiplied by the resistance they have inputed
            VoltageofEachComponent = CurrentofEachJunction * ResistanceOfEachComponent;
            Force = MagneticFluxDensity * CurrentofEachJunction * Length;
            SinDirection = Force / (MagneticFluxDensity * CurrentofEachJunction * Length);
            Direction = Math.Asin(SinDirection);
            return 0;

        }
    }
}
