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
        gameshowhannguEntities context;
        public LED1()
        {
            InitializeComponent();
        }

        private void LED1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            // hide taskbar
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        

        private void LED1_Load_1(object sender, EventArgs e)
        {
            //this.TopMost = true;
            // hide taskbar
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            timerStatus.Start();
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = context.status_led.FirstOrDefault(x => x.id == 1);
            if(status.count_status == 1)
            {
                LED2 led2 = new LED2();
                led2.Show();
                this.Hide();
                timerStatus.Stop();
            }
        }
    }
}
