﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigame
{
    public partial class TS4 : Form
    {
        public TS4()
        {
            InitializeComponent();
        }

        private void TS4_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }


        private void timerCount_Tick(object sender, EventArgs e)
        {

        }
    }
}
