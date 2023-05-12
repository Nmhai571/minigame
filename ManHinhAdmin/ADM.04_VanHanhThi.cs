﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManHinhAdmin
{
    public partial class ADM4 : Form
    {
        gameshowhannguEntities context;
        public ADM4()
        {
            InitializeComponent();
        }

        private void ADM_Load(object sender, EventArgs e)
        {

        }

        private void btnBatDau1_Click(object sender, EventArgs e)
        {

            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName1.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();


            var nextQuestionLed = context.next_question_led.Find(1);
            nextQuestionLed.next_led_status = 1;


            var recheckStatus = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName1.Text
                          select new { s, q }).FirstOrDefault();
            var statusQuestion = context.questions.Find(status.q.id_question);
            btnStatus1.Text = recheckStatus.s.name_status;
            btnStatus1.BackColor = Color.Yellow;

            var nextQuestion = context.status_next_question.Find(1);
            nextQuestion.count_status_next_question = 1;
            context.SaveChanges();
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName1.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();


            var statusQuestion1 = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName1.Text
                                  select new { s, q }).FirstOrDefault();
            btnStatus1.Text = statusQuestion1.s.name_status;
            btnStatus1.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();

        }

        private void btnBatDau2_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName2.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();

            var nextQuestionLed = context.next_question_led.Find(1);
            nextQuestionLed.next_led_status = 1;


            var status1 = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName2.Text
                          select new { s, q }).FirstOrDefault();
            btnStatus2.Text = status1.s.name_status;
            btnStatus2.BackColor = Color.Yellow;

            var nextQuestion = context.status_next_question.Find(1);
            nextQuestion.count_status_next_question = 1;

            context.SaveChanges();
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName2.Text
                                  select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();


            var statusQuestion1 = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName2.Text
                                  select new { s, q }).FirstOrDefault();
            btnStatus2.Text = statusQuestion1.s.name_status;
            btnStatus2.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();
        }

        private void btnBatDau3_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName3.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();


            var nextQuestionLed = context.next_question_led.Find(1);
            nextQuestionLed.next_led_status = 1;


            var status1 = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName3.Text
                          select new { s, q }).FirstOrDefault();
            btnStatus3.Text = status1.s.name_status;
            btnStatus3.BackColor = Color.Yellow;

            var nextQuestion = context.status_next_question.Find(1);
            nextQuestion.count_status_next_question = 1;
            context.SaveChanges();
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName3.Text
                                  select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();


            var statusQuestion1 = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName3.Text
                                  select new { s, q }).FirstOrDefault();
            btnStatus3.Text = statusQuestion1.s.name_status;
            btnStatus3.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();
        }

        private void btnBatDau4_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName4.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();

            var nextQuestionLed = context.next_question_led.Find(1);
            nextQuestionLed.next_led_status = 1;


            var status1 = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName4.Text
                          select new { s, q }).FirstOrDefault();
            btnStatus4.Text = status1.s.name_status;
            btnStatus4.BackColor = Color.Yellow;

            var nextQuestion = context.status_next_question.Find(1);
            nextQuestion.count_status_next_question = 1;
            context.SaveChanges();
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName4.Text
                                  select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();


            var statusQuestion1 = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName4.Text
                                  select new { s, q }).FirstOrDefault();
            btnStatus4.Text = statusQuestion1.s.name_status;
            btnStatus4.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();


        }

        private void btnBatDau5_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName5.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();

            var nextQuestionLed = context.next_question_led.Find(1);
            nextQuestionLed.next_led_status = 1;


            var status1 = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName5.Text
                          select new { s, q }).FirstOrDefault();
            btnStatus5.Text = status1.s.name_status;
            btnStatus5.BackColor = Color.Yellow;

            var nextQuestion = context.status_next_question.Find(1);
            nextQuestion.count_status_next_question = 1;
            context.SaveChanges();
        }

        private void btnAnswer5_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName5.Text
                                  select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();


            var statusQuestion1 = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName5.Text
                                  select new { s, q }).FirstOrDefault();
            btnStatus5.Text = statusQuestion1.s.name_status;
            btnStatus5.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();
        }

        private void btnBatDau6_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName6.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();

            var nextQuestionLed = context.next_question_led.Find(1);
            nextQuestionLed.next_led_status = 1;


            var status1 = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName6.Text
                          select new { s, q }).FirstOrDefault();
            btnStatus6.Text = status1.s.name_status;
            btnStatus6.BackColor = Color.Yellow;

            var nextQuestion = context.status_next_question.Find(1);
            nextQuestion.count_status_next_question = 1;
            context.SaveChanges();
        }

        private void btnAnswer6_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName6.Text
                                  select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();


            var statusQuestion1 = (from s in context.statusses
                                 join q in context.questions on s.id_status equals q.id_status
                                 where q.name_question == lbName6.Text
                                 select new { s, q }).FirstOrDefault();
            btnStatus6.Text = statusQuestion1.s.name_status;
            btnStatus6.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();
        }

        private void btnBatDau7_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName7.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();

            var nextQuestionLed = context.next_question_led.Find(1);
            nextQuestionLed.next_led_status = 1;


            var status1 = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName7.Text
                          select new { s, q }).FirstOrDefault();
            btnStatus7.Text = status1.s.name_status;
            btnStatus7.BackColor = Color.Yellow;

            var nextQuestion = context.status_next_question.Find(1);
            nextQuestion.count_status_next_question = 1;
            context.SaveChanges();
        }

        private void btnAnswer7_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName7.Text
                                  select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();


            var statusQuestion1 = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName7.Text
                                  select new { s, q }).FirstOrDefault();
            btnStatus7.Text = statusQuestion1.s.name_status;
            btnStatus7.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();
        }

        private void btnBatDau8_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName8.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();

            var nextQuestionLed = context.next_question_led.Find(1);
            nextQuestionLed.next_led_status = 1;

            var status1 = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName8.Text
                          select new { s, q }).FirstOrDefault();
            btnStatus8.Text = status1.s.name_status;
            btnStatus8.BackColor = Color.Yellow;

            var nextQuestion = context.status_next_question.Find(1);
            nextQuestion.count_status_next_question = 1;
            context.SaveChanges();
        }

        private void btnAnswer8_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName8.Text
                                  select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();

            var statusQuestion1 = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName8.Text
                                  select new { s, q }).FirstOrDefault();
            btnStatus8.Text = statusQuestion1.s.name_status;
            btnStatus8.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();
        }

        private void btnBatDau9_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName9.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();

            var nextQuestionLed = context.next_question_led.Find(1);
            nextQuestionLed.next_led_status = 1;


            var status1 = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName9.Text
                          select new { s, q }).FirstOrDefault();
            btnStatus9.Text = status1.s.name_status;
            btnStatus9.BackColor = Color.Yellow;

            var nextQuestion = context.status_next_question.Find(1);
            nextQuestion.count_status_next_question = 1;
            context.SaveChanges();
        }

        private void btnAnswer9_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName9.Text
                                  select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();


            var statusQuestion1 = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName9.Text
                                  select new { s, q }).FirstOrDefault();
            btnStatus9.Text = statusQuestion1.s.name_status;
            btnStatus9.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();
        }

        private void btnBatDau10_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var status = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName10.Text
                          select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(status.q.id_question);
            statusChange.id_status = 2;
            context.SaveChanges();

            var nextQuestionLed = context.next_question_led.Find(1);
            nextQuestionLed.next_led_status = 1;


            var status1 = (from s in context.statusses
                          join q in context.questions on s.id_status equals q.id_status
                          where q.name_question == lbName10.Text
                          select new { s, q }).FirstOrDefault();
            btnStatus10.Text = status1.s.name_status;
            btnStatus10.BackColor = Color.Yellow;

            var nextQuestion = context.status_next_question.Find(1);
            nextQuestion.count_status_next_question = 1;
            context.SaveChanges();
        }

        private void btnAnswer10_Click(object sender, EventArgs e)
        {
            context = new gameshowhannguEntities();
            var statusQuestion = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName10.Text
                                  select new { s, q }).FirstOrDefault();
            var statusChange = context.questions.Find(statusQuestion.q.id_question);
            statusChange.id_status = 3;
            context.SaveChanges();


            var statusQuestion1 = (from s in context.statusses
                                  join q in context.questions on s.id_status equals q.id_status
                                  where q.name_question == lbName10.Text
                                  select new { s, q }).FirstOrDefault();
            btnStatus10.Text = statusQuestion1.s.name_status;
            btnStatus10.BackColor = Color.Green;

            var statusLed = context.status_led.Find(1);
            statusLed.count_status = 2;
            context.SaveChanges();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ADM3 admin3 = new ADM3();
            admin3.Show();
            this.Hide();
            
        }
    }
}
