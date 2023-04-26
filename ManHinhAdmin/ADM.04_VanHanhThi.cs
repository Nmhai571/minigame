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

namespace ManHinhAdmin
{
    public partial class ADM4 : Form
    {
        gameshowhannguEntities context = new gameshowhannguEntities();
        public ADM4()
        {
            InitializeComponent();
        }

        private void ADM_Load(object sender, EventArgs e)
        {

        }

        private void btnBatDau1_Click(object sender, EventArgs e)
        {
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName1.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();

            btnStatus1.Text = status.s.name_status;
            btnStatus1.BackColor = Color.Green;
        }
    }
}
