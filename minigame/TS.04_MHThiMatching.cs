using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace minigame
{
    public partial class TS4 : Form
    {
        gameshowhannguEntities context = new gameshowhannguEntities();
        public TS4()
        {
            InitializeComponent();
        }

        private void TS4_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }
        private bool labelSelected = false;
        int countDown = 10;
        private void timerCount_Tick(object sender, EventArgs e)
        {

        }

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
                    answers = string.Concat(lbAnswerA.Text, cbAnswer1.Text),
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
                    answers = string.Concat(lbAnswerA.Text, cbAnswer1.Text),
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
                    answers = string.Concat(lbAnswerC.Text, cbAnswer3.Text),
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
                    answers = string.Concat(lbAnswerD.Text, cbAnswer4.Text),
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
                lbAnswerA.Cursor = Cursors.Hand;
                lbAnswerA.ForeColor = Color.White;
            }
        }

        private void lbAnswerB_MouseLeave(object sender, EventArgs e)
        {
            lbAnswerA.ForeColor = Color.Black;

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
            lbAnswerA.ForeColor = Color.Black;

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
            lbAnswerA.ForeColor = Color.Black;

        }

        private void lbAnswerA_Click_1(object sender, EventArgs e)
        {

        }
    }
}
