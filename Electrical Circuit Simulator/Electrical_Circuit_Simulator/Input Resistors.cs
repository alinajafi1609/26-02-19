using System;
using System.Windows.Forms;

namespace Electrical_Circuit_Simulator

{ public partial class Input_Resistors : Form
{
    double Voltage;
    double Resistance;
    string name;
    string PorS;
    int Junction;
    public bool PictureOrder;
    Circuit cir;

    public Input_Resistors(Circuit circut)
    {
        InitializeComponent();
            cir = circut;
    }

    private void Enter_Click(object sender, EventArgs e)
    {
        this.Invalidate();
        this.Close();

            //Checker = true;
            //name = nameTextBox.Text;

            //string SResistance = resTextBox.Text;
            //if (SResistance != "?" && !string.IsNullOrEmpty(SResistance))
            //{
            //    Resistance = Convert.ToDouble(SResistance);
            //}

            //string SVoltage = voltageTexBox.Text;
            //if (SVoltage != "?" && !string.IsNullOrEmpty(SVoltage))
            //{
            //    Voltage = Convert.ToDouble(SVoltage);
            //}
        PictureOrder = true;
        var component = new ComponentResistors(Resistance, name, Junction);
        cir.ComponentResistorList.Add(component);
        Console.WriteLine("");
    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string JunctionS = textBox1.Text;
            Junction = Convert.ToInt16(JunctionS);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            //CCS InputName = new CCS(Name);
        }

        private void Input_Resistors_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string SResistance = resTextBox.Text;
            if (SResistance != "?" && !string.IsNullOrEmpty(SResistance))
            {
                Resistance = Convert.ToDouble(SResistance);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

