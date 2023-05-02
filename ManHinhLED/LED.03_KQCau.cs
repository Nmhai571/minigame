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

namespace ManHinhLED
{
    public partial class LED3 : Form
    {
        gameshowhannguEntities context;
        public LED3()
        {
            InitializeComponent();
        }

        private void LED3_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            // this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            timerKQCau.Start();
            timerShowAnswer.Start();
        }

        private void timerKQCau_Tick(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusTeam = context.status_team.Find(1);
            if (statusTeam.count_team == 1)
            {
                var student = from stu in context.students
                              join teams in context.team_battle on stu.id_team equals teams.id_team
                              join answer in context.answers_of_student on stu.id_student equals answer.id_student
                              join question in context.questions on answer.id_question equals question.id_question
                              join statusQuestion in context.statusses on question.id_status equals statusQuestion.id_status
                              where teams.id_team == statusTeam.count_team && statusQuestion.id_status == 2
                              select new { stu, answer, question };
                if(student != null)
                {
                    List<KQCauViewModel> ltsStudent = new List<KQCauViewModel>();
                    foreach (var item in student)
                    {
                        MemoryStream stream = new MemoryStream(item.question.img_question);

                        Image imgQuestion = Image.FromStream(stream);
                        pbImageQuestion.Image = imgQuestion;
                        lbNameQuestion.Text = item.question.name_question;

                        KQCauViewModel kqCau = new KQCauViewModel();
                        kqCau.Fullname = item.stu.fullname;
                        kqCau.TimeOfStudent = item.answer.time_of_answer;
                        kqCau.AnswerOfStudent = item.answer.answers;
                        ltsStudent.Add(kqCau);
                    }
                    for (int i = 0; ;)
                    {
                        lbNameStudent1.Text = ltsStudent[i].Fullname;
                        lbNameStudent2.Text = ltsStudent[i + 1].Fullname;
                        lbNameStudent3.Text = ltsStudent[i + 2].Fullname;
                        lbNameStudent4.Text = ltsStudent[i + 3].Fullname;
                        lbNameStudent5.Text = ltsStudent[i + 4].Fullname;
                        lbNameStudent6.Text = ltsStudent[i + 5].Fullname;

                        lbTime1.Text = Convert.ToString(ltsStudent[i].TimeOfStudent);
                        lbTime2.Text = Convert.ToString(ltsStudent[i + 1].TimeOfStudent);
                        lbTime3.Text = Convert.ToString(ltsStudent[i + 2].TimeOfStudent);
                        lbTime4.Text = Convert.ToString(ltsStudent[i + 3].TimeOfStudent);
                        lbTime5.Text = Convert.ToString(ltsStudent[i + 4].TimeOfStudent);
                        lbTime6.Text = Convert.ToString(ltsStudent[i + 5].TimeOfStudent);

                        lbAnswer1.Text = ltsStudent[i].AnswerOfStudent;
                        lbAnswer2.Text = ltsStudent[i + 1].AnswerOfStudent;
                        lbAnswer3.Text = ltsStudent[i + 2].AnswerOfStudent;
                        lbAnswer4.Text = ltsStudent[i + 3].AnswerOfStudent;
                        lbAnswer5.Text = ltsStudent[i + 4].AnswerOfStudent;
                        lbAnswer6.Text = ltsStudent[i + 5].AnswerOfStudent;
                        break;
                    }
                    this.Refresh();

                }

            }
        }

        private void timerShowAnswer_Tick(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusLed = context.status_led.Find(1);
            if (statusLed.count_status == 2)
            {
                var answer = context.questions.FirstOrDefault(x => x.name_question.Equals(lbNameQuestion.Text));

                lbAnswerQuestion.Text = answer.true_answer;
                statusLed.count_status = 1;
                this.Refresh();
                timerKQCau.Stop();
                timerShowAnswer.Stop();
            }
        }
    }
}
