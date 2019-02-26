using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Electrical_Circuit_Simulator.Forms
{
    public partial class PS : Form
    {
        public PS()
        {
            Bitmap Background = new Bitmap("C:\\Users\\Ali Najafi\\Desktop\\Electrical Circuit Simulator\\Electrical Circuit Simulator\\Electrical_Circuit_Simulator\\Resources\\PECs Backround.jpg");
            this.BackgroundImage = Background;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var CCS = new CCS();

            CCS.Show();
            Visible = false;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Back = new Menu();
            Back.Show();
            Visible = false;
        }

        private void PS_Load(object sender, EventArgs e)
        {

        }

        //private void PS_Load(object sender, EventArgs e)
        //{

        //}
    }
}
