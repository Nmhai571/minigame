using System;
using System.Data;
using System.Drawing;
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
        }
        int countDown = 10;
        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            countDown--;
            lbTime.Text = countDown.ToString();
            if (countDown == 0)
            {
                timerCountDown.Stop();
            }

            if(cbAnswer1.Text != "" && cbAnswer2.Text != "" && cbAnswer3.Text != "" && cbAnswer4.Text != "")
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
                    answers = lbAnswerA.Text +"-"+ cbAnswer1.Text +", " + lbAnswerB.Text + "-" + cbAnswer2.Text + ", " + lbAnswerC.Text + "-" + cbAnswer3.Text + ", " + lbAnswerD.Text +"-" + cbAnswer4.Text,
                    time_of_answer = 10 - countDown
                };
                context.answers_of_student.Add(answer);
                context.SaveChanges();
            }
        }
    }
}
