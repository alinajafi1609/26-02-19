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
    public partial class Input_Electromagnet : Form
    {
        Circuit cir;
        double MagneticFluxDensity;
        double Length;
        string name;
        int Junction;
        double Resistance;
        public Input_Electromagnet(Circuit circut)
        {
            InitializeComponent();
            cir = circut;
        }

        private void Input_Electromagnet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Close();
            var component = new ComponentElectromagnets(MagneticFluxDensity, Length, name, Junction, Resistance);
            cir.ComponentElectromagnetsList.Add(component);
            Console.WriteLine("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string MagneticFluxDensityString = textBox1.Text;
            if (MagneticFluxDensityString != "?" && !string.IsNullOrEmpty(MagneticFluxDensityString))
            {
                MagneticFluxDensity = Convert.ToDouble(MagneticFluxDensityString);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string SLengthString = textBox1.Text;
            if (SLengthString != "?" && !string.IsNullOrEmpty(SLengthString))
            {
                Length = Convert.ToDouble(SLengthString);
            }
        }

        private void resTextBox_TextChanged(object sender, EventArgs e)
        {
            string JunctionS = textBox1.Text;
            Junction = Convert.ToInt16(JunctionS);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string SResistance = textBox3.Text;
            if (SResistance != "?" && !string.IsNullOrEmpty(SResistance))
            {
                Resistance = Convert.ToDouble(SResistance);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
