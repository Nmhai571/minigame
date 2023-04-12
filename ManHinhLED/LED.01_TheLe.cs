using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManHinhLED
{
    public partial class LED1 : Form
    {
        public LED1()
        {
            InitializeComponent();
        }

        private void LED_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            // hide taskbar
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
