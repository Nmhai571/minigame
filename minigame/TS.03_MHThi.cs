using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace minigame
{
    public partial class TS3 : Form
    {
        gameshowhannguEntities context;
        public TS3()
        {
            InitializeComponent();
        }

        private void TS_Load(object sender, EventArgs e)
        {
            timerQuestion.Start();
            timerCount.Start();
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }
        private bool labelSelected = false;
        int countDown = 11;

        private void lbAnswerA_Click(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
                timerCount.Stop();
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
                    answers = lbAnswerA.Text,
                    time_of_answer = 10 - countDown
                };
                context.answers_of_student.Add(answer);
                context.SaveChanges();
                lbAnswerA.ForeColor = Color.White;
                lbAnswerA.MouseLeave -= lbAnswerA_MouseLeave;
                labelSelected = true;
            }
        }

        private void lbAnswerB_Click(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
                timerCount.Stop();
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
                    answers = lbAnswerB.Text,
                    time_of_answer = 10 - countDown
                };

                context.answers_of_student.Add(answer);
                context.SaveChanges();
                lbAnswerB.ForeColor = Color.White;
                lbAnswerB.MouseLeave -= lbAnswerB_MouseLeave;
                labelSelected = true;


            }
        }

        private void lbAnswerC_Click(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
                timerCount.Stop();
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
                    answers = lbAnswerC.Text,
                    time_of_answer = 10 - countDown

                };

                context.answers_of_student.Add(answer);
                context.SaveChanges();
                lbAnswerC.ForeColor = Color.White;
                lbAnswerC.MouseLeave -= lbAnswerB_MouseLeave;
                labelSelected = true;
            }
        }

        private void lbAnswerD_Click(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
                timerCount.Stop();
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
                    answers = lbAnswerD.Text,
                    time_of_answer = 10 - countDown

                };
                context.answers_of_student.Add(answer);
                context.SaveChanges();
                lbAnswerD.ForeColor = Color.White;
                lbAnswerD.MouseLeave -= lbAnswerB_MouseLeave;
                labelSelected = true;
            }
        }

        private void lbAnswerA_MouseHover(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
                lbAnswerA.Cursor = Cursors.Hand;
                lbAnswerA.ForeColor = Color.White;
            }


        }
        private void lbAnswerA_MouseLeave(object sender, EventArgs e)
        {
            lbAnswerA.ForeColor = Color.Black;

        }

        private void lbAnswerB_MouseHover(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
                lbAnswerB.Cursor = Cursors.Hand;
                lbAnswerB.ForeColor = Color.White;
            }
        }

        private void lbAnswerB_MouseLeave(object sender, EventArgs e)
        {
            lbAnswerB.ForeColor = Color.Black;
        }

        private void lbAnswerC_MouseHover(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
                lbAnswerC.Cursor = Cursors.Hand;
                lbAnswerC.ForeColor = Color.White;
            }
        }

        private void lbAnswerC_MouseLeave(object sender, EventArgs e)
        {
            lbAnswerC.ForeColor = Color.Black;

        }

        private void lbAnswerD_MouseHover(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
                lbAnswerD.Cursor = Cursors.Hand;
                lbAnswerD.ForeColor = Color.White;
            }
        }

        private void lbAnswerD_MouseLeave(object sender, EventArgs e)
        {
            lbAnswerD.ForeColor = Color.Black;

        }




        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            if (timerCount.Enabled == false)
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
                            labelSelected = false;
                            //TS3 ts3 = new TS3();
                            lbNameThi.Text = status.students.fullname;
                            lbTeamThi.Text = status.team.name_team;
                            lbNameCauHoi.Text = status.question.name_question;
                            MemoryStream stream = new MemoryStream(status.question.img_question);
                            Image imgQuestion = Image.FromStream(stream);
                            pbAnhThi.Image = imgQuestion;
                            countDown = 11;
                            timerCount.Start();
                            this.Refresh();
                        }
                        else
                        {
                            labelSelected = false;
                            TS4 ts4 = new TS4();
                            ts4.lbNameThi.Text = status.students.fullname;
                            ts4.lbTeamThi.Text = status.team.name_team;
                            ts4.lbNameCauHoi.Text = status.question.name_question;
                            MemoryStream stream = new MemoryStream(status.question.img_question);
                            Image imgQuestion = Image.FromStream(stream);
                            ts4.pbAnhThi.Image = imgQuestion;
                            ts4.Show();
                            this.Hide();
                        }
                    }
                }
            }



        }

        private void timerCount_Tick(object sender, EventArgs e)
        {
            --countDown;
            lbCountDown.Text = countDown.ToString();
            Console.WriteLine(lbCountDown.Text);
            if (countDown == 0)
            {
                timerCount.Stop();
                if (labelSelected == false)
                {
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
                        answers = null,
                        time_of_answer = null

                    };

                    context.answers_of_student.Add(answer);
                    context.SaveChanges();
                    labelSelected = true;
                    timerCount.Stop();

                }
            }
        }
    }
}
