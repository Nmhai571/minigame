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
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
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
            // lấy dữ liệu vào từng lable
            for(int i=0; ;)
            {
                admin4.lbName1.Text = dataName[i];
                admin4.lbName2.Text = dataName[i+1];
                admin4.lbName3.Text = dataName[i+2];
                /*admin4.lbName4.Text = dataName[i+3];
                admin4.lbName5.Text = dataName[i+4];
                admin4.lbName6.Text = dataName[i+5];
                admin4.lbName7.Text = dataName[i+6];
                admin4.lbName8.Text = dataName[i+7];
                admin4.lbName9.Text = dataName[i+8];
                admin4.lbName10.Text = dataName[i+9];*/
                break;
            }

            admin4.Show();
            this.Hide();
        }
    }
}
