﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            PaintGrid(new Size(50, 50));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.PaintGrid(new Size(50, 50));
        }
    }
}
