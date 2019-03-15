using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Electrical_Circuit_Simulator
{
    public partial class Input_Capacitor : Form
    {
        double Voltage;
        double Resistance;
        string name;
        string PorS;
        int Junction;
        double Capacitance;
        double Charge;
        public bool PictureOrder;
        Circuit cir;
        public Input_Capacitor(Circuit circut)
        {
            InitializeComponent();
            cir = circut;
        }

        private void Input_Capactior_Load(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string SResistance = resTextBox.Text;
            if (SResistance != "?" && !string.IsNullOrEmpty(SResistance))
            {
                Resistance = Convert.ToDouble(SResistance);
            }
        }

        private void resTextBox_TextChanged(object sender, EventArgs e)
        {

            string JunctionS = textBox1.Text;
            Junction = Convert.ToInt16(JunctionS);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string SCapacitance = resTextBox.Text;
            if (SCapacitance != "?" && !string.IsNullOrEmpty(SCapacitance))
            {
                Capacitance = Convert.ToDouble(SCapacitance);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string SCharge = resTextBox.Text;
            if (SCharge != "?" && !string.IsNullOrEmpty(SCharge))
            {
                Charge = Convert.ToDouble(SCharge);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Close();
            var component = new ComponentCapacitor(Capacitance, Resistance, name, Junction, Charge);
            cir.ComponentCapacitorList.Add(component);
            Console.WriteLine("");
        }
    }
}
