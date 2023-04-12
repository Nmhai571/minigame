using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManHinhAdmin
{
    public partial class ADM4 : Form
    {
        public ADM4()
        {
            InitializeComponent();
        }

        private void ADM4_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
           // this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
