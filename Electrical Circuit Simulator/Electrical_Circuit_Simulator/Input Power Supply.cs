using System;
using System.Windows.Forms;

namespace Electrical_Circuit_Simulator
{
    public partial class Input_Power_Supply : Form
    {
        Circuit cir;
        double Volt;
        double InternalResistance;
        string name;
        public Input_Power_Supply(Circuit circuit)
        {
            InitializeComponent();
            cir = circuit;
        }

        private void Input_Power_Supply_Load(object sender, EventArgs e)
        {
        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {
                string InputName = textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var component = new ComponentPowerSource(Volt, InternalResistance, name);
            cir.ComponentPowerSourceList.Add(component);
            Console.WriteLine("");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                string EMF = textBox1.Text;
                double SEMF = Convert.ToDouble(EMF);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                string SIntertalResistance = textBox1.Text;
                double InternalResistance = Convert.ToDouble(SIntertalResistance);
        }
    }
}
