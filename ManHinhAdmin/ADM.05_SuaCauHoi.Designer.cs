namespace ManHinhAdmin
{
    partial class ADM5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbQuestionType = new System.Windows.Forms.ComboBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pbQuestion = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbAddQuestionName = new System.Windows.Forms.TextBox();
            this.cbAddTopic = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbTopic = new System.Windows.Forms.ComboBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.tbPoint = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbQuestionType
            // 
            this.cbQuestionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuestionType.FormattingEnabled = true;
            this.cbQuestionType.Location = new System.Drawing.Point(442, -26);
            this.cbQuestionType.Name = "cbQuestionType";
            this.cbQuestionType.Size = new System.Drawing.Size(33, 24);
            this.cbQuestionType.TabIndex = 17;
            this.cbQuestionType.Text = "Loại Câu Hỏi";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChooseImage.Location = new System.Drawing.Point(62, 388);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(141, 44);
            this.btnChooseImage.TabIndex = 16;
            this.btnChooseImage.Text = "Chọn Ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pbQuestion
            // 
            this.pbQuestion.Location = new System.Drawing.Point(62, 105);
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.Size = new System.Drawing.Size(523, 261);
            this.pbQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion.TabIndex = 15;
            this.pbQuestion.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.Location = new System.Drawing.Point(360, 486);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(225, 51);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(62, 486);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(231, 51);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbAddQuestionName
            // 
            this.tbAddQuestionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddQuestionName.Location = new System.Drawing.Point(186, 61);
            this.tbAddQuestionName.Name = "tbAddQuestionName";
            this.tbAddQuestionName.Size = new System.Drawing.Size(118, 22);
            this.tbAddQuestionName.TabIndex = 11;
            this.tbAddQuestionName.TextChanged += new System.EventHandler(this.tbAddQuestionName_TextChanged);
            // 
            // cbAddTopic
            // 
            this.cbAddTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddTopic.FormattingEnabled = true;
            this.cbAddTopic.Location = new System.Drawing.Point(162, -26);
            this.cbAddTopic.Name = "cbAddTopic";
            this.cbAddTopic.Size = new System.Drawing.Size(33, 24);
            this.cbAddTopic.TabIndex = 10;
            this.cbAddTopic.Text = "Bộ Đề";
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(389, 12);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(196, 24);
            this.cbType.TabIndex = 19;
            // 
            // cbTopic
            // 
            this.cbTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTopic.FormattingEnabled = true;
            this.cbTopic.Location = new System.Drawing.Point(62, 12);
            this.cbTopic.Name = "cbTopic";
            this.cbTopic.Size = new System.Drawing.Size(196, 24);
            this.cbTopic.TabIndex = 18;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnswer.Location = new System.Drawing.Point(467, 61);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(118, 22);
            this.tbAnswer.TabIndex = 20;
            // 
            // tbPoint
            // 
            this.tbPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPoint.Location = new System.Drawing.Point(343, 61);
            this.tbPoint.Name = "tbPoint";
            this.tbPoint.Size = new System.Drawing.Size(118, 22);
            this.tbPoint.TabIndex = 21;
            // 
            // tbId
            // 
            this.tbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbId.Location = new System.Drawing.Point(62, 61);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(118, 22);
            this.tbId.TabIndex = 22;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // ADM5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 752);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbPoint);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbTopic);
            this.Controls.Add(this.cbQuestionType);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.pbQuestion);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbAddQuestionName);
            this.Controls.Add(this.cbAddTopic);
            this.Name = "ADM5";
            this.Text = "ADM.05_SuaCauHoi";
            this.Load += new System.EventHandler(this.ADM5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbQuestionType;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbAddTopic;
        public System.Windows.Forms.ComboBox cbTopic;
        public System.Windows.Forms.ComboBox cbType;
        public System.Windows.Forms.TextBox tbAddQuestionName;
        public System.Windows.Forms.TextBox tbPoint;
        public System.Windows.Forms.TextBox tbAnswer;
        public System.Windows.Forms.PictureBox pbQuestion;
        public System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}