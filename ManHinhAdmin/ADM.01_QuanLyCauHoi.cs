using System;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace ManHinhAdmin
{
    public partial class ADM1 : Form
    {
        gameshowhannguEntities context = new gameshowhannguEntities();
        public ADM1()
        {
            InitializeComponent();
        }

        private void ADM1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            LoadData();
            LoadDataBinding();
        }

        #region method

        public void LoadDataBinding()
        {
            tbId.DataBindings.Add(new Binding("Text", dgvCauHoi.DataSource, "Id"));
        }
        public void LoadData()
        {
            var data = from q in context.questions
                       join t in context.question_topic on q.id_topic equals t.id_topic
                       join qt in context.question_type on q.id_question_type equals qt.id
                       select new
                       {
                           Id = q.id_question,
                           Name = q.name_question,
                           Image = q.img_question,
                           Answer = q.true_answer,
                           Point = q.point,
                           Topic = t.name_topic,
                           Type = qt.type_of_name
                       };

                       
            dgvCauHoi.DataSource = data.ToList();
        }

        public void DeleteQuestion()
        {
            var deleteQuesion = context.questions.Find(int.Parse(tbId.Text) );
            if (deleteQuesion == null)
            {
                MessageBox.Show($"can not find question with Id: {tbId.Text}");
            }
            else
            {
                context.questions.Remove(deleteQuesion);
                context.SaveChanges();
                MessageBox.Show("successful delete");
                ADM1 admin1 = new ADM1();
                admin1.Show();
                this.Hide();
            }
        }
        #endregion
       

        private void btnAddQ_Click(object sender, EventArgs e)
        {
            ADM2 admin2 = new ADM2();
            admin2.Show();
            this.Hide();
        }

        private void btnDeleteQ_Click(object sender, EventArgs e)
        {
            DeleteQuestion();
        }

        private void btnEditQ_Click(object sender, EventArgs e)
        {
            ADM5 admin5  = new ADM5();
            
            var id = int.Parse(tbId.Text);
            var data = from q in context.questions
                       join t in context.question_topic on q.id_topic equals t.id_topic
                       join qt in context.question_type on q.id_question_type equals qt.id
                       where(q.id_question == id)
                       select new
                       {
                           Id = q.id_question,
                           Name = q.name_question,
                           Images = q.img_question,
                           Answer = q.true_answer,
                           Point = q.point,
                           Topic = t.name_topic,
                           Type = qt.type_of_name
                       };

            if (data == null)
            {
                MessageBox.Show($"can not find question with id: {id}");
            }
            else
            {
                foreach ( var item in data )
                {
                    MemoryStream stream = new MemoryStream(item.Images);
                    Image imgQuestion = Image.FromStream(stream);
                    admin5.tbId.Text = item.Id.ToString();
                    admin5.cbTopic.Text = item.Topic;
                    admin5.cbType.Text = item.Type;
                    admin5.tbAddQuestionName.Text = item.Name;
                    admin5.tbPoint.Text = item.Point.ToString();
                    admin5.tbAnswer.Text = item.Answer;
                    admin5.pbQuestion.Image = imgQuestion;
                }
            }
            admin5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADM3 admin3 = new ADM3();
            admin3.Show();
            this.Hide();
        }

        private void btnXemCauHoi_Click(object sender, EventArgs e)
        {
            var ledCount = context.status_led.Find(1);
            ledCount.count_status = 1;
            context.SaveChanges();
        }

        
    }
}
