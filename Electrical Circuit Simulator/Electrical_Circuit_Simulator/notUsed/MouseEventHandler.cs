using System.Windows.Forms;

namespace System
{
    // nousage
    internal class MouseEventHandler
    {
        private Action<object, MouseEventArgs> toolStripButton1_Click_1;

        public MouseEventHandler(Action<object, MouseEventArgs> toolStripButton1_Click_1)
        {
            this.toolStripButton1_Click_1 = toolStripButton1_Click_1;
        }
    }
}