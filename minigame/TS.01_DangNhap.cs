using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigame
{
    public partial class TS1 : Form
    {
        gameshowhannguEntities context = new gameshowhannguEntities();
        public TS1()
        {
            InitializeComponent();
        }

        private void TS1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        #region method

        void Login()
        {
            var student = from s in context.students
                          .Where(x => x.name_account.Equals(tbAccount.Text) && x.pass.Equals(tbPassword.Text))
                          join t in context.team_battle on s.id_team equals t.id_team
                          select new
                          {
                              Name = s.fullname,
                              Team = t.name_team
                          };
            if(string.IsNullOrEmpty(tbAccount.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Thể Trống!!!");
            }
            TS2 ts2 = new TS2();
            foreach (var item in student)
            {
                if (item != null)
                {
                    ts2.lbName.Text = item.Name;
                    ts2.lbTeam.Text = item.Team;
                    ts2.Show();
                    this.Hide();
                }
                else MessageBox.Show("tài khoản hoặc mật khẩu không đúng!!!");
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
