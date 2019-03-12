namespace Electrical_Circuit_Simulator
{
    partial class CCS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCS));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.bulbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resistorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableResistorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalWireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalWireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button3 = new System.Windows.Forms.Button();
            this.variableElectromagnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "SI Units";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Circuit Symbols";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(922, 519);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(857, 519);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 30);
            this.button5.TabIndex = 7;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 470);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(984, 25);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulbToolStripMenuItem,
            this.resistorToolStripMenuItem,
            this.variableResistorToolStripMenuItem,
            this.cellToolStripMenuItem,
            this.batteryToolStripMenuItem,
            this.magnetToolStripMenuItem,
            this.variableElectromagnetToolStripMenuItem,
            this.verticalWireToolStripMenuItem,
            this.horizontalWireToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(120, 22);
            this.toolStripSplitButton1.Text = "Add Component";
            // 
            // bulbToolStripMenuItem
            // 
            this.bulbToolStripMenuItem.Name = "bulbToolStripMenuItem";
            this.bulbToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.bulbToolStripMenuItem.Text = "Bulb";
            this.bulbToolStripMenuItem.Click += new System.EventHandler(this.bulbToolStripMenuItem_Click);
            // 
            // resistorToolStripMenuItem
            // 
            this.resistorToolStripMenuItem.Name = "resistorToolStripMenuItem";
            this.resistorToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.resistorToolStripMenuItem.Text = "Resistor";
            this.resistorToolStripMenuItem.Click += new System.EventHandler(this.resistorToolStripMenuItem_Click);
            // 
            // variableResistorToolStripMenuItem
            // 
            this.variableResistorToolStripMenuItem.Name = "variableResistorToolStripMenuItem";
            this.variableResistorToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.variableResistorToolStripMenuItem.Text = "Variable Resistor";
            this.variableResistorToolStripMenuItem.Click += new System.EventHandler(this.variableResistorToolStripMenuItem_Click);
            // 
            // cellToolStripMenuItem
            // 
            this.cellToolStripMenuItem.Name = "cellToolStripMenuItem";
            this.cellToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cellToolStripMenuItem.Text = "Cell";
            this.cellToolStripMenuItem.Click += new System.EventHandler(this.cellToolStripMenuItem_Click);
            // 
            // batteryToolStripMenuItem
            // 
            this.batteryToolStripMenuItem.Name = "batteryToolStripMenuItem";
            this.batteryToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.batteryToolStripMenuItem.Text = "Battery";
            this.batteryToolStripMenuItem.Click += new System.EventHandler(this.batteryToolStripMenuItem_Click);
            // 
            // magnetToolStripMenuItem
            // 
            this.magnetToolStripMenuItem.Name = "magnetToolStripMenuItem";
            this.magnetToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.magnetToolStripMenuItem.Text = "Electromagnet";
            this.magnetToolStripMenuItem.Click += new System.EventHandler(this.magnetToolStripMenuItem_Click);
            // 
            // verticalWireToolStripMenuItem
            // 
            this.verticalWireToolStripMenuItem.Name = "verticalWireToolStripMenuItem";
            this.verticalWireToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.verticalWireToolStripMenuItem.Text = "Vertical Wire";
            this.verticalWireToolStripMenuItem.Click += new System.EventHandler(this.verticalWireToolStripMenuItem_Click);
            // 
            // horizontalWireToolStripMenuItem
            // 
            this.horizontalWireToolStripMenuItem.Name = "horizontalWireToolStripMenuItem";
            this.horizontalWireToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.horizontalWireToolStripMenuItem.Text = "Horizontal Wire";
            this.horizontalWireToolStripMenuItem.Click += new System.EventHandler(this.horizontalWireToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Clear ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "CALCULATE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // variableElectromagnetToolStripMenuItem
            // 
            this.variableElectromagnetToolStripMenuItem.Name = "variableElectromagnetToolStripMenuItem";
            this.variableElectromagnetToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.variableElectromagnetToolStripMenuItem.Text = "Variable Electromagnet";
            this.variableElectromagnetToolStripMenuItem.Click += new System.EventHandler(this.variableElectromagnetToolStripMenuItem_Click);
            // 
            // CCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CCS";
            this.Text = "Circuit Construction Software";
            this.Load += new System.EventHandler(this.CCS_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem bulbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resistorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variableResistorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batteryToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem magnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalWireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalWireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variableElectromagnetToolStripMenuItem;
    }
}