using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Size currentGridSize = new Size(30,30);
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.PaintGrid(new Size(50, 50));
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "30x30")
            {
                currentGridSize = new Size(30, 30);
                this.PaintGrid(currentGridSize);
            } 
            else if(toolStripComboBox1.Text == "50x50")
            {
                currentGridSize = new Size(50, 50);
                this.PaintGrid(currentGridSize);
            }
            else
            {
                currentGridSize = new Size(80, 80);
                this.PaintGrid(currentGridSize);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.PaintGrid(currentGridSize);
        }

        private void toolStripComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            this.PaintGrid(currentGridSize);
        }
    }
}
