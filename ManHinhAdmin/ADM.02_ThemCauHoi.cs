using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManHinhAdmin
{
    public partial class ADM2 : Form
    {
        gameshowhannguEntities context = new gameshowhannguEntities();
        public ADM2()
        {
            InitializeComponent();
        }

        private void ADM2_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            LoadData();
        }



        #region method

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            ofdOpenFile.ShowDialog();
            string filePath = ofdOpenFile.FileName;
            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }
            Image questionImage = Image.FromFile(filePath);
            pbQuestion.Image = questionImage;

        }
        void LoadData()
        {
            foreach (var item in context.question_topic)
            {
                cbAddTopic.Items.Add(item.name_topic);
            }
            foreach (var item in context.question_type)
            {
                cbQuestionType.Items.Add(item.type_of_name);
            }

        }

        void AddQuestion()
        {
            MemoryStream stream = new MemoryStream();
            pbQuestion.Image.Save(stream, ImageFormat.Png);
            var resultTopic = (from qt in context.question_topic
                               where qt.name_topic == cbAddTopic.Text
                               select qt).FirstOrDefault();

            var resultTypeQuestion = (from qt in context.question_type
                                      where qt.type_of_name == cbQuestionType.Text
                                      select qt).FirstOrDefault();

            question question = new question()
            {
                name_question = tbAddQuestionName.Text,
                point = 1,
                id_status = 1,
                id_topic = resultTopic.id_topic,
                true_answer = tbAddAnswer.Text,
                id_question_type = resultTypeQuestion.id,
                img_question = stream.ToArray(),
            };

            context.questions.Add(question);
            context.SaveChanges();

            ADM1 admin1 = new ADM1();
            admin1.Show();
            this.Hide();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddQuestion();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ADM1 admin1 = new ADM1();
            admin1.Show();
            this.Hide();
        }
    }
}
