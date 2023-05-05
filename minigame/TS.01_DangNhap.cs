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
            var student = (from s in context.students
                          .Where(x => x.name_account.Equals(tbAccount.Text) && x.pass.Equals(tbPassword.Text))
                           join t in context.team_battle on s.id_team equals t.id_team
                           select new
                           {
                               s,
                               t
                           }).FirstOrDefault();



            if (string.IsNullOrEmpty(tbAccount.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Your Username Or Password Cannot Be Null");
            }
            else
            {
                if (student == null)
                {
                    MessageBox.Show("The Username Or Password You Entered Is Incorrect!!!!");
                }
                else
                {
                    TS2 ts2 = new TS2();
                    ts2.lbName.Text = student.s.fullname;
                    ts2.lbTeam.Text = student.t.name_team;
                    MessageBox.Show("Successfully Logs In");
                    ts2.Show();
                    this.Hide();

                }
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
