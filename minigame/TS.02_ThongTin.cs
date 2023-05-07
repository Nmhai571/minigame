using ManHinhLED.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigame
{
    public partial class TS2 : Form
    {
        gameshowhannguEntities context;
        public TS2()
        {
            InitializeComponent();
        }

        private void TS2_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            TS4 ts4 = new TS4();
            TS3 ts3 = new TS3();
            var status = (from statuss in context.statusses
                          join question in context.questions on statuss.id_status equals question.id_status
                          join qtype in context.question_type on question.id_question_type equals qtype.id
                          join qtopic in context.question_topic on question.id_topic equals qtopic.id_topic
                          join team in context.team_battle on qtopic.id_topic equals team.id_topic
                          join students in context.students on team.id_team equals students.id_team
                          where statuss.id_status == 2 && students.fullname.Equals(lbName.Text) && team.name_team.Equals(lbTeam.Text)
                          select new { statuss, question, students, team, qtype }).FirstOrDefault();
            if (status != null)
            {
                if (status.qtype.id == 1)
                {
                    ts3.lbNameThi.Text = status.students.fullname;
                    ts3.lbTeamThi.Text = status.team.name_team;
                    ts3.lbNameCauHoi.Text = status.question.name_question;
                    MemoryStream stream = new MemoryStream(status.question.img_question);
                    Image imgQuestion = Image.FromStream(stream);
                    ts3.pbAnhThi.Image = imgQuestion;   
                    ts3.Show();
                    this.Hide();
                    timer.Stop();
                }
                else
                {
                    ts4.lbNameThi.Text = status.students.fullname;
                    ts4.lbTeamThi.Text = status.team.name_team;
                    ts4.lbNameCauHoi.Text = status.question.name_question;
                    MemoryStream stream = new MemoryStream(status.question.img_question);
                    Image imgQuestion = Image.FromStream(stream);
                    ts4.pbAnhThi.Image = imgQuestion;
                    ts4.Show();
                    this.Hide();
                    timer.Stop();
                }
            }

        }

    }
}
