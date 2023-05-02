using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManHinhAdmin
{
    public partial class ADM4 : Form
    {
        gameshowhannguEntities context;
        public ADM4()
        {
            InitializeComponent();
        }

        private void ADM_Load(object sender, EventArgs e)
        {

        }

        private void btnBatDau1_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName1.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();

            btnStatus1.Text = status.s.name_status;
            btnStatus1.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADM1 admin1 = new ADM1();
            admin1.Show();
            this.Hide();
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName1.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();

            btnStatus1.Text = statusQuestion.s.name_status;
            btnStatus1.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();

        }
    }
}
