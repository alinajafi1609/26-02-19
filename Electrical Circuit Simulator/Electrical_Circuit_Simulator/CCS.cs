using System;
using System.Windows.Forms;
using System.Threading;
using Electrical_Circuit_Simulator.Forms;
using Electrical_Circuit_Simulator.Forms.Physics;
using System.Drawing;
namespace Electrical_Circuit_Simulator
{
    public partial class CCS : Form
    {
        private Bitmap Bmp;
        private Point BmpLoc;
        string ComponentNameLabel;
        bool CheckerLabel;
        Circuit circuit;
        //true if point1 must be updated
        //false if point2 must be updated
        //update point1 or point2
        public CCS()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            Paint += new PaintEventHandler(panel1_Paint);
            circuit = new Circuit();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)  
        {

            Invalidate();
        }
        //Buttons, for closing and back...
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread theThread = new Thread(StartGame);
            theThread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            var SIUnits = new SI();
            SIUnits.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var CircuitSymbols = new Symbols();
            CircuitSymbols.Show();
        }

        private void calc_Click(object sender, EventArgs e)
        {
        }
        public void StartGame()
        {
            Game1 game = new Game1();
            game.Run();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Back = new PS();
            Back.Show();
            Visible = false;
        }
        PictureBox Component;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (Bmp != null)

            {
                Component = new PictureBox();
                Label ComponentName = new Label();
                ComponentName.Location = new Point(23, 50);
                ComponentName.Text = ComponentNameLabel;
                Component.SizeMode = PictureBoxSizeMode.AutoSize;
                Component.Location = new Point(x, y);
                Component.Image = Image.FromFile(FileLocation);
                this.panel1.Controls.Add(Component);
                Component.Controls.Add(ComponentName);
                Component.BackColor = Color.Transparent;
                Bmp = null;
                this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
                Component.MouseDown += new System.Windows.Forms.MouseEventHandler(Component_MouseDown);
                Component.MouseMove += new System.Windows.Forms.MouseEventHandler(Component_MouseMove);
                Component.MouseUp += new System.Windows.Forms.MouseEventHandler(Component_MouseUp);
            }
        }
        int x = 0;
        int y = 0;
        bool drag = false;
        private void Component_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            drag = true;
        }
        private void Component_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Component.Top += e.Y - y;
                Component.Left += e.X - x;
            }
        }
        private void Component_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        Graphics g;
        bool canPaint = false;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            canPaint = false;
            prevX = null;
            prevY = null;
        }
        private void toolStripButton10_Click(object sender, EventArgs e)
        {

        }
        private void CCS_Load(object sender, EventArgs e)
        {
        }

        int? prevX = null;
        string FileLocation = "";
        private void resistorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputResistors = new Input_Resistors(circuit);
            InputResistors.Show();
            FileLocation = ".\\..\\..\\..\\Resources\\ResistorCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
            x = 1;
        }

        private void variableResistorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputResistors = new Input_Resistors(circuit);
            InputResistors.Show();
            FileLocation = ".\\..\\..\\..\\Resources\\VRCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
            y = 2;
        }

        private void cellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputPower = new Input_Power_Supply(circuit);
            InputPower.Show();
            FileLocation = ".\\..\\..\\..\\Resources\\CellCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }

        private void batteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputPower = new Input_Power_Supply(circuit);
            InputPower.Show();
            FileLocation = ".\\..\\..\\..\\Resources\\BatteryCS.png";
            Bmp = new Bitmap(FileLocation);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }


        int? prevY = null;
        int CprevX = 0;
        int CprevY = 0;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Pen!!!!!
            if (canPaint)
            {
                Pen pen = new Pen(Color.Black, 3);
                //g.DrawLine(pen, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
                prevX = e.X;
                prevY = e.Y;
            }
            //Component

        }
        Point POINT = new Point(400, 40);

        private void bulbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputResistors = new Input_Resistors(circuit);
            InputResistors.Show();
            FileLocation = ".\\..\\..\\..\\Resources\\BULBCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, 80);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
            panel1.Controls.Clear();
        }

        private void voltmeterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLocation = ".\\..\\..\\..\\Resources\\VoltMeterCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }

        private void ammeterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLocation = ".\\..\\..\\..\\Resources\\AmmeterCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }

        private bool pictOrder;

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            circuit.calculate();
        }

        private void magnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputElectromagnets = new Input_Electromagnet(circuit);
            InputElectromagnets.Show();
            FileLocation = ".\\..\\..\\..\\Resources\\ElectromagnetCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }

        private void verticalWireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLocation = ".\\..\\..\\..\\Resources\\VerticalWire.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }

        private void horizontalWireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLocation = ".\\..\\..\\..\\Resources\\HorizontalWire.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }

        private void variableElectromagnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputElectromagnets = new Input_Electromagnet(circuit);
            InputElectromagnets.Show();
            FileLocation = ".\\..\\..\\..\\Resources\\VariableElectromagnetCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }
    }
    }
