using System;
using System.Data;
using System.Drawing;
using System.Linq;
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
            timerCount.Start();
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }
        private bool labelSelected = false;
        int countDown = 10;

        private void lbAnswerA_Click(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
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
                timerCount.Stop();
            }
        }

        private void lbAnswerB_Click(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
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
                timerCount.Stop();

            }
        }

        private void lbAnswerC_Click(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
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
                timerCount.Stop();

            }
        }

        private void lbAnswerD_Click(object sender, EventArgs e)
        {
            if (labelSelected == false)
            {
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
                timerCount.Stop();

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


        private void timerCount_Tick_1(object sender, EventArgs e)
        {
            countDown--;
            lbCountDown.Text = countDown.ToString();
        }
    }
}
