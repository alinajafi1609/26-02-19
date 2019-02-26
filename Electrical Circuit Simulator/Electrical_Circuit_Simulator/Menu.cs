using Electrical_Circuit_Simulator.Forms;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            Bitmap Background = new Bitmap("C:\\Users\\Ali Najafi\\Desktop\\Electrical Circuit Simulator\\Electrical Circuit Simulator\\Electrical_Circuit_Simulator\\Resources\\PECs Backround.jpg");
            this.BackgroundImage = Background;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var PS = new PS();
            PS.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var help = new HELP();
            help.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
