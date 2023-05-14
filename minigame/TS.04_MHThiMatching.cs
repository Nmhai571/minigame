using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace minigame
{
    public partial class TS4 : Form
    {
        gameshowhannguEntities context;
        public TS4()
        {
            InitializeComponent();
        }

        private void TS4_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            timerCountDown.Start();
            timerNextQuestion.Start();
        }
        int countDown = 11;
        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            countDown--;
            lbTime.Text = countDown.ToString();
            if (countDown == 0)
            {
                timerCountDown.Stop();
            }

            if (cbAnswer1.Text != "" && cbAnswer2.Text != "" && cbAnswer3.Text != "" && cbAnswer4.Text != "")
            {
                timerCountDown.Stop();
                context = new gameshowhannguEntities();
                var question = (from q in context.questions
                                select q)
                               .FirstOrDefault(x => x.name_question.Equals(lbNameCauHoi.Text));
                var student = (from s in context.students
                               select s)
                               .FirstOrDefault(x => x.fullname.Equals(lbNameThi.Text));
                answers_of_student answer = new answers_of_student()
                {
                    id_student = student.id_student,
                    id_question = question.id_question,
                    answers = lbAnswerA.Text + "-" + cbAnswer1.Text + ", " + lbAnswerB.Text + "-" + cbAnswer2.Text + ", " + lbAnswerC.Text + "-" + cbAnswer3.Text + ", " + lbAnswerD.Text + "-" + cbAnswer4.Text,
                    time_of_answer = 10 - countDown
                };
                context.answers_of_student.Add(answer);
                context.SaveChanges();
            }
        }

        private void timerNextQuestion_Tick(object sender, EventArgs e)
        {
            if (timerCountDown.Enabled == false)
            {
                var nextQuestion = context.status_next_question.Find(1);
                if (nextQuestion.count_status_next_question == 1)
                {
                    nextQuestion.count_status_next_question = 0;
                    context.SaveChanges();


                    var status = (from statuss in context.statusses
                                  join question in context.questions on statuss.id_status equals question.id_status
                                  join qtype in context.question_type on question.id_question_type equals qtype.id
                                  join qtopic in context.question_topic on question.id_topic equals qtopic.id_topic
                                  join team in context.team_battle on qtopic.id_topic equals team.id_topic
                                  join students in context.students on team.id_team equals students.id_team
                                  where statuss.id_status == 2 && students.fullname.Equals(lbNameThi.Text) && team.name_team.Equals(lbTeamThi.Text)
                                  select new { statuss, question, students, team, qtype }).FirstOrDefault();
                    if (status != null)
                    {


                        if (status.qtype.id == 1)
                        {
                            TS3 ts3 = new TS3();
                            ts3.lbNameThi.Text = status.students.fullname;
                            ts3.lbTeamThi.Text = status.team.name_team;
                            ts3.lbNameCauHoi.Text = status.question.name_question;
                            MemoryStream stream = new MemoryStream(status.question.img_question);
                            Image imgQuestion = Image.FromStream(stream);
                            ts3.pbAnhThi.Image = imgQuestion;
                            ts3.Show();
                            this.Hide();
                        }
                        else
                        {
                            //TS4 ts4 = new TS4();
                            lbNameThi.Text = status.students.fullname;
                            lbTeamThi.Text = status.team.name_team;
                            lbNameCauHoi.Text = status.question.name_question;
                            MemoryStream stream = new MemoryStream(status.question.img_question);
                            Image imgQuestion = Image.FromStream(stream);
                            pbAnhThi.Image = imgQuestion;
                            countDown = 11;
                            timerCountDown.Start();
                            this.Refresh();
                        }
                    }
                }
            }
        }
    }
}
