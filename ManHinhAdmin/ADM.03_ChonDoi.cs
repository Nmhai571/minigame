using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ManHinhAdmin
{
    public partial class ADM3 : Form
    {
        gameshowhannguEntities context = new gameshowhannguEntities();
        public ADM3()
        {
            InitializeComponent();
        }

        private void ADM_Load(object sender, EventArgs e)
        {
            GetNameOfTeam();
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        #region method

        void GetNameOfTeam()
        {
            var team = from t in context.team_battle select t;
            foreach (var item in team)
            {
                cbTeamBattle.Items.Add(item.name_team);
            }
        }

        void ChooseTeam()
        {
            ADM4 admin4 = new ADM4();
            var data = from q in context.questions
                       join qt in context.question_topic on q.id_topic equals qt.id_topic
                       join tb in context.team_battle on qt.id_topic equals tb.id_topic
                       where tb.name_team == cbTeamBattle.Text
                       select new { q, tb, qt };
            List<string> dataName = new List<string>();
            foreach (var item in data)
            {
                admin4.lbTeamBattle.Text = item.tb.name_team;
                admin4.lbTopic.Text = item.qt.name_topic;
                dataName.Add(item.q.name_question);

            }
            var count = dataName.Count();
            // lấy dữ liệu vào từng lable
            for (int i = 0; ;)
            {
                if (count == 1)
                {
                    admin4.lbName1.Text = dataName[i];
                    break;

                }
                if (count == 2)
                {
                    admin4.lbName1.Text = dataName[i];
                    admin4.lbName2.Text = dataName[i + 1];
                    break;

                }
                if (count == 3)
                {
                    admin4.lbName1.Text = dataName[i];
                    admin4.lbName2.Text = dataName[i + 1];
                    admin4.lbName3.Text = dataName[i + 2];
                    break;
                }
                if (count == 4)
                {
                    admin4.lbName1.Text = dataName[i];
                    admin4.lbName2.Text = dataName[i + 1];
                    admin4.lbName3.Text = dataName[i + 2];
                    admin4.lbName4.Text = dataName[i + 3];
                    break;
                }
                if (count == 5)
                {
                    admin4.lbName1.Text = dataName[i];
                    admin4.lbName2.Text = dataName[i + 1];
                    admin4.lbName3.Text = dataName[i + 2];
                    admin4.lbName4.Text = dataName[i + 3];
                    admin4.lbName5.Text = dataName[i + 4];
                    break;
                }
                if (count == 6)
                {
                    admin4.lbName1.Text = dataName[i];
                    admin4.lbName2.Text = dataName[i + 1];
                    admin4.lbName3.Text = dataName[i + 2];
                    admin4.lbName4.Text = dataName[i + 3];
                    admin4.lbName5.Text = dataName[i + 4];
                    admin4.lbName6.Text = dataName[i + 5];
                    break;
                }
                if (count == 7)
                {
                    admin4.lbName1.Text = dataName[i];
                    admin4.lbName2.Text = dataName[i + 1];
                    admin4.lbName3.Text = dataName[i + 2];
                    admin4.lbName4.Text = dataName[i + 3];
                    admin4.lbName5.Text = dataName[i + 4];
                    admin4.lbName6.Text = dataName[i + 5];
                    admin4.lbName7.Text = dataName[i + 6];
                    break;
                }
                if (count == 8)
                {
                    admin4.lbName1.Text = dataName[i];
                    admin4.lbName2.Text = dataName[i + 1];
                    admin4.lbName3.Text = dataName[i + 2];
                    admin4.lbName4.Text = dataName[i + 3];
                    admin4.lbName5.Text = dataName[i + 4];
                    admin4.lbName6.Text = dataName[i + 5];
                    admin4.lbName7.Text = dataName[i + 6];
                    admin4.lbName8.Text = dataName[i + 7];
                    break;
                }
                if (count == 9)
                {
                    admin4.lbName1.Text = dataName[i];
                    admin4.lbName2.Text = dataName[i + 1];
                    admin4.lbName3.Text = dataName[i + 2];
                    admin4.lbName4.Text = dataName[i + 3];
                    admin4.lbName5.Text = dataName[i + 4];
                    admin4.lbName6.Text = dataName[i + 5];
                    admin4.lbName7.Text = dataName[i + 6];
                    admin4.lbName8.Text = dataName[i + 7];
                    admin4.lbName9.Text = dataName[i + 8];
                    break;
                }
                if (count == 10)
                {
                    admin4.lbName1.Text = dataName[i];
                    admin4.lbName2.Text = dataName[i + 1];
                    admin4.lbName3.Text = dataName[i + 2];
                    admin4.lbName4.Text = dataName[i + 3];
                    admin4.lbName5.Text = dataName[i + 4];
                    admin4.lbName6.Text = dataName[i + 5];
                    admin4.lbName7.Text = dataName[i + 6];
                    admin4.lbName8.Text = dataName[i + 7];
                    admin4.lbName9.Text = dataName[i + 8];
                    admin4.lbName10.Text = dataName[i + 9];
                    break;
                }

            }
            MessageBox.Show("Success");
            admin4.Show();
            this.Hide();


        }

        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var team = (from t in context.team_battle
                        where t.name_team == cbTeamBattle.Text
                        select t).FirstOrDefault();
            if(team == null)
            {
                MessageBox.Show("Please Choose One Of The Team.");
            }
            else
            {
                if (team.id_team == 1)
                {
                    var statusTeam = context.status_team.Find(1);
                    statusTeam.count_team = 1;
                    context.SaveChanges();
                    ChooseTeam();
                }
                if (team.id_team == 2)
                {
                    var statusTeam = context.status_team.Find(1);
                    statusTeam.count_team = 2;
                    context.SaveChanges();
                    ChooseTeam();
                }
                if (team.id_team == 3)
                {
                    var statusTeam = context.status_team.Find(1);
                    statusTeam.count_team = 3;
                    context.SaveChanges();
                    ChooseTeam();
                }
                if (team.id_team == 4)
                {
                    var statusTeam = context.status_team.Find(1);
                    statusTeam.count_team = 4;
                    context.SaveChanges();
                    ChooseTeam();
                }
                if (team.id_team == 5)
                {
                    var statusTeam = context.status_team.Find(1);
                    statusTeam.count_team = 1;
                    context.SaveChanges();
                    ChooseTeam();
                }
                if (team.id_team == 6)
                {
                    var statusTeam = context.status_team.Find(1);
                    statusTeam.count_team = 1;
                    context.SaveChanges();
                    ChooseTeam();
                }
            }
            
        }
    }
}
