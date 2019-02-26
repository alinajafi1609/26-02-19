using System;
using System.Drawing;

namespace Electrical_Circuit_Simulator
{
    // no usage
    internal class Form1_MouseDown1
    {
        private Point p1;
        private Point p2;

        public Form1_MouseDown1(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public static implicit operator Point(Form1_MouseDown1 v)
        {
            throw new NotImplementedException();
        }
    }
}