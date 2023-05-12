using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ManHinhLED
{
    public partial class LED2 : Form
    {
        gameshowhannguEntities context;
        public LED2()
        {
            InitializeComponent();
        }


        private void LED2_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            timerDSTeam.Start();
        }

        private void timerDSTeam_Tick(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            LED3 led3;
            var team = context.status_team.FirstOrDefault(x => x.id == 1);
            if (team.count_team == 1)
            {
                led3 = new LED3();
                var student = from stu in context.students
                              join teams in context.team_battle on stu.id_team equals teams.id_team
                              where teams.id_team == team.count_team
                              select stu;
                var question = (from que in context.questions
                                join sta in context.statusses on que.id_status equals sta.id_status
                                where que.id_status == 2
                                select que).FirstOrDefault();

                if (question != null)
                {
                    MemoryStream stream = new MemoryStream(question.img_question);
                    Image imgQuestion = Image.FromStream(stream);
                    led3.pbImageQuestion.Image = imgQuestion;
                    led3.lbNameQuestion.Text = question.name_question;
                    led3.Show();
                    this.Hide();
                    timerDSTeam.Stop();

                }
                /* if (question != null)
                 {
                     List<string> ltsStudent = new List<string>();
                     foreach (var item in student)
                     {

                         ltsStudent.Add(item.fullname);
                     }
                     int count = ltsStudent.Count;

                     for (int i = 0; ;)
                     {
                         if (count == 1)
                         {
                             led3.lbNameStudent1.Text = ltsStudent[i];
                             led3.Show();
                             this.Hide();
                             break;

                         }
                         if (count == 2)
                         {
                             led3.lbNameStudent1.Text = ltsStudent[i];
                             led3.lbNameStudent2.Text = ltsStudent[i + 1];
                             led3.Show();
                             this.Hide();
                             timerDSTeam.Stop();
                             break;
                         }
                         if (count == 3)
                         {
                             led3.lbNameStudent1.Text = ltsStudent[i];
                             led3.lbNameStudent2.Text = ltsStudent[i + 1];
                             led3.lbNameStudent3.Text = ltsStudent[i + 2];
                             led3.Show();
                             this.Hide();
                             timerDSTeam.Stop();

                             break;
                         }
                         if (count == 4)
                         {
                             led3.lbNameStudent1.Text = ltsStudent[i];
                             led3.lbNameStudent2.Text = ltsStudent[i + 1];
                             led3.lbNameStudent3.Text = ltsStudent[i + 2];
                             led3.lbNameStudent4.Text = ltsStudent[i + 3];

                             timerDSTeam.Stop();

                             break;

                         }
                         if (count == 5)
                         {
                             led3.lbNameStudent1.Text = ltsStudent[i];
                             led3.lbNameStudent2.Text = ltsStudent[i + 1];
                             led3.lbNameStudent3.Text = ltsStudent[i + 2];
                             led3.lbNameStudent4.Text = ltsStudent[i + 3];
                             led3.lbNameStudent5.Text = ltsStudent[i + 4];
                             led3.Show();
                             this.Hide();

                             break;

                         }
                         if (count == 6)
                         {
                             led3.lbNameStudent1.Text = ltsStudent[i];
                             led3.lbNameStudent2.Text = ltsStudent[i + 1];
                             led3.lbNameStudent3.Text = ltsStudent[i + 2];
                             led3.lbNameStudent4.Text = ltsStudent[i + 3];
                             led3.lbNameStudent5.Text = ltsStudent[i + 4];
                             led3.lbNameStudent6.Text = ltsStudent[i + 5];
                             led3.Show();
                             this.Hide();
                             timerDSTeam.Stop();

                             break;
                         }
                         break;

                     }
                 }*/

            }

            if (team.count_team == 2)
            {
                led3 = new LED3();
                var student = from stu in context.students
                              join teams in context.team_battle on stu.id_team equals teams.id_team
                              where teams.id_team == team.count_team
                              select stu;
                var question = (from que in context.questions
                                join sta in context.statusses on que.id_status equals sta.id_status
                                where sta.id_status == 2
                                select que).FirstOrDefault();

                if (question != null)
                {
                    MemoryStream stream = new MemoryStream(question.img_question);
                    Image imgQuestion = Image.FromStream(stream);
                    led3.pbImageQuestion.Image = imgQuestion;
                    led3.lbNameQuestion.Text = question.name_question;
                }
                List<string> ltsStudent = new List<string>();
                foreach (var item in student)
                {

                    ltsStudent.Add(item.fullname);
                }
                var count = ltsStudent.Count;
                for (int i = 0; ;)
                {
                    
                    if (count == 1)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();
                        break;

                    }
                    if (count == 2)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();
                        break;
                    }
                    if (count == 3)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();
                        break;
                    }
                    if (count == 4)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();
                        break;

                    }
                    if (count == 5)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.lbNameStudent5.Text = ltsStudent[i + 4];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();
                        break;

                    }
                    if (count == 6)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.lbNameStudent5.Text = ltsStudent[i + 4];
                        led3.lbNameStudent6.Text = ltsStudent[i + 5];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();
                        break;
                    }

                    break;
                }
            }

            if (team.count_team == 3)
            {
                led3 = new LED3();
                var student = from stu in context.students
                              join teams in context.team_battle on stu.id_team equals teams.id_team
                              where teams.id_team == team.count_team
                              select stu;
                var question = (from que in context.questions
                                join sta in context.statusses on que.id_status equals sta.id_status
                                where sta.id_status == 2
                                select que).FirstOrDefault();
                
              
                List<string> ltsStudent = new List<string>();
                foreach (var item in student)
                {

                    ltsStudent.Add(item.fullname);
                }
                if (question != null)
                {
                    MemoryStream stream = new MemoryStream(question.img_question);
                    Image imgQuestion = Image.FromStream(stream);
                    led3.pbImageQuestion.Image = imgQuestion;
                    led3.lbNameQuestion.Text = question.name_question;
                }
                var count = ltsStudent.Count;
                for (int i = 0; ;)
                {
                    if (count == 1)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.Show();
                        this.Hide();
                        break;

                    }
                    if (count == 2)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();
                        break;
                    }
                    if (count == 3)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;
                    }
                    if (count == 4)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;

                    }
                    if (count == 5)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.lbNameStudent5.Text = ltsStudent[i + 4];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;

                    }
                    if (count == 6)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.lbNameStudent5.Text = ltsStudent[i + 4];
                        led3.lbNameStudent6.Text = ltsStudent[i + 5];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;
                    }
                    break;

                }
            }

            if (team.count_team == 4)
            {
                led3 = new LED3();
                var student = from stu in context.students
                              join teams in context.team_battle on stu.id_team equals teams.id_team
                              where teams.id_team == team.count_team
                              select stu;
                var question = (from que in context.questions
                                join sta in context.statusses on que.id_status equals sta.id_status
                                where sta.id_status == 2
                                select que).FirstOrDefault();
                List<string> ltsStudent = new List<string>();
                foreach (var item in student)
                {

                    ltsStudent.Add(item.fullname);
                }
                if (question != null)
                {
                    MemoryStream stream = new MemoryStream(question.img_question);
                    Image imgQuestion = Image.FromStream(stream);
                    led3.pbImageQuestion.Image = imgQuestion;
                    led3.lbNameQuestion.Text = question.name_question;
                }
                var count = ltsStudent.Count;
                for (int i = 0; ;)
                {
                    if (count == 1)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.Show();
                        this.Hide();
                        break;

                    }
                    if (count == 2)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();
                        break;
                    }
                    if (count == 3)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;
                    }
                    if (count == 4)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;

                    }
                    if (count == 5)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.lbNameStudent5.Text = ltsStudent[i + 4];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;

                    }
                    if (count == 6)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.lbNameStudent5.Text = ltsStudent[i + 4];
                        led3.lbNameStudent6.Text = ltsStudent[i + 5];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;
                    }
                    break;

                }
            }

            if (team.count_team == 5)
            {
                led3 = new LED3();
                var student = from stu in context.students
                              join teams in context.team_battle on stu.id_team equals teams.id_team
                              where teams.id_team == team.count_team
                              select stu;
                var question = (from que in context.questions
                                join sta in context.statusses on que.id_status equals sta.id_status
                                where sta.id_status == 2
                                select que).FirstOrDefault();
                List<string> ltsStudent = new List<string>();
                foreach (var item in student)
                {

                    ltsStudent.Add(item.fullname);
                }
                if (question != null)
                {
                    MemoryStream stream = new MemoryStream(question.img_question);
                    Image imgQuestion = Image.FromStream(stream);
                    led3.pbImageQuestion.Image = imgQuestion;
                    led3.lbNameQuestion.Text = question.name_question;
                }
                var count = ltsStudent.Count;
                for (int i = 0; ;)
                {
                    if (count == 1)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.Show();
                        this.Hide();
                        break;

                    }
                    if (count == 2)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();
                        break;
                    }
                    if (count == 3)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;
                    }
                    if (count == 4)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;

                    }
                    if (count == 5)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.lbNameStudent5.Text = ltsStudent[i + 4];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;

                    }
                    if (count == 6)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.lbNameStudent5.Text = ltsStudent[i + 4];
                        led3.lbNameStudent6.Text = ltsStudent[i + 5];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;
                    }
                    break;

                }
            }

            if (team.count_team == 6)
            {
                led3 = new LED3();
                var student = from stu in context.students
                              join teams in context.team_battle on stu.id_team equals teams.id_team
                              where teams.id_team == team.count_team
                              select stu;
                var question = (from que in context.questions
                                join sta in context.statusses on que.id_status equals sta.id_status
                                where sta.id_status == 2
                                select que).FirstOrDefault();
                List<string> ltsStudent = new List<string>();
                foreach (var item in student)
                {

                    ltsStudent.Add(item.fullname);
                }
                if (question != null)
                {
                    MemoryStream stream = new MemoryStream(question.img_question);
                    Image imgQuestion = Image.FromStream(stream);
                    led3.pbImageQuestion.Image = imgQuestion;
                    led3.lbNameQuestion.Text = question.name_question;
                }
                var count = ltsStudent.Count;
                for (int i = 0; ;)
                {
                    if (count == 1)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.Show();
                        this.Hide();
                        break;

                    }
                    if (count == 2)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();
                        break;
                    }
                    if (count == 3)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;
                    }
                    if (count == 4)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;

                    }
                    if (count == 5)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.lbNameStudent5.Text = ltsStudent[i + 4];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;

                    }
                    if (count == 6)
                    {
                        led3.lbNameStudent1.Text = ltsStudent[i];
                        led3.lbNameStudent2.Text = ltsStudent[i + 1];
                        led3.lbNameStudent3.Text = ltsStudent[i + 2];
                        led3.lbNameStudent4.Text = ltsStudent[i + 3];
                        led3.lbNameStudent5.Text = ltsStudent[i + 4];
                        led3.lbNameStudent6.Text = ltsStudent[i + 5];
                        led3.Show();
                        this.Hide();
                        timerDSTeam.Stop();

                        break;
                    }
                    break;

                }
            }
        }
    }
}
