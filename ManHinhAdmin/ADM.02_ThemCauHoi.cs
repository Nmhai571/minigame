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
using System.Text.RegularExpressions;

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
            var resultTopic = (from qt in context.question_topic
                               where qt.name_topic == cbAddTopic.Text
                               select qt).FirstOrDefault();

            var resultTypeQuestion = (from qt in context.question_type
                                      where qt.type_of_name == cbQuestionType.Text
                                      select qt).FirstOrDefault();
            if (resultTopic == null || resultTypeQuestion == null || tbAddQuestionName.Text == "" || tbAddAnswer.Text == "" || pbQuestion.Image == null)
            {
                MessageBox.Show("Please Enter Full Details");
            }
            else
            {
                if (resultTypeQuestion.id == 1)
                {
                    pbQuestion.Image.Save(stream, ImageFormat.Png);
                    question question = new question()
                    {

                        name_question = tbAddQuestionName.Text, // message
                        point = 1,
                        id_status = 1,
                        id_topic = resultTopic.id_topic,
                        true_answer = tbAddAnswer.Text,// message
                        id_question_type = resultTypeQuestion.id,
                        img_question = stream.ToArray(), // message
                    };
                    context.questions.Add(question);
                    context.SaveChanges();
                    MessageBox.Show("Add Question Successfully");
                    ADM1 admin1 = new ADM1();
                    admin1.Show();
                    this.Hide();
                }
                else
                {
                    pbQuestion.Image.Save(stream, ImageFormat.Png);
                    question question = new question()
                    {

                        name_question = tbAddQuestionName.Text, // message
                        point = 1,
                        id_status = 1,
                        id_topic = resultTopic.id_topic,
                        true_answer = tbAddAnswer.Text,// message
                        id_question_type = resultTypeQuestion.id,
                        img_question = stream.ToArray(), // message
                    };
                    string pattern = @"^(?=(?:.*[A-D]-[1-4]){4})[A-D]-[1-4](?:,\s*[A-D]-[1-4]){3}$";
                    bool isMatch = Regex.IsMatch(question.true_answer, pattern);
                    if(isMatch == true)
                    {
                        context.questions.Add(question);
                        context.SaveChanges();
                        MessageBox.Show("Add Question Successfully");
                        ADM1 admin1 = new ADM1();
                        admin1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter The Correct Answer Format");
                    }
                    
                    

                   
                    
                }
                
            }

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
