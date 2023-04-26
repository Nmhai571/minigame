using System;
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
    public partial class TS3 : Form
    {
        gameshowhannguEntities context = new gameshowhannguEntities();
        public TS3()
        {
            InitializeComponent();
        }

        private void TS_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

    
    }
}
