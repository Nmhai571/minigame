using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ManHinhAdmin
{
    public partial class ADM5 : Form
    {
        gameshowhannguEntities context = new gameshowhannguEntities();
        public ADM5()
        {
            InitializeComponent();
           

        }
        private void ADM5_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbAddQuestionName_TextChanged(object sender, EventArgs e)
        {
            
        }

        #region method
        void LoadData()
        {
            foreach (var item in context.question_topic)
            {
                cbTopic.Items.Add(item.name_topic);
            }
            foreach (var item in context.question_type)
            {
                cbType.Items.Add(item.type_of_name);
            }

        }

        void Update()
        {
            MemoryStream stream = new MemoryStream();
            pbQuestion.Image.Save(stream, ImageFormat.Png);
            var resultTopic = (from qt in context.question_topic
                               where qt.name_topic == cbTopic.Text
                               select qt).FirstOrDefault();

            var resultTypeQuestion = (from qt in context.question_type
                                      where qt.type_of_name == cbType.Text
                                      select qt).FirstOrDefault();
            var question = context.questions.Find(int.Parse(tbId.Text));
            question.name_question = tbAddQuestionName.Text;
            question.true_answer = tbAnswer.Text;
            question.point = int.Parse(tbPoint.Text);
            question.id_question_type = resultTypeQuestion.id;
            question.id_topic = resultTopic.id_topic;
            question.img_question = stream.ToArray();
            context.SaveChanges();

        }


        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Update();
            ADM1 admin1 = new ADM1();
            admin1.Show();
            this.Hide();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            ofdFile.ShowDialog();
            string filePath = ofdFile.FileName;
            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }
            Image questionImage = Image.FromFile(filePath);
            pbQuestion.Image = questionImage;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ADM1 admin1 = new ADM1();
            admin1.Show();
            this.Hide();
        }
    }
}
