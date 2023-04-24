namespace ManHinhAdmin
{
    partial class ADM2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbQuestionType = new System.Windows.Forms.ComboBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pbQuestion = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbAddAnswer = new System.Windows.Forms.TextBox();
            this.tbAddQuestionName = new System.Windows.Forms.TextBox();
            this.cbAddTopic = new System.Windows.Forms.ComboBox();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbQuestionType);
            this.panel1.Controls.Add(this.btnChooseImage);
            this.panel1.Controls.Add(this.pbQuestion);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbAddAnswer);
            this.panel1.Controls.Add(this.tbAddQuestionName);
            this.panel1.Controls.Add(this.cbAddTopic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 636);
            this.panel1.TabIndex = 0;
            // 
            // cbQuestionType
            // 
            this.cbQuestionType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuestionType.FormattingEnabled = true;
            this.cbQuestionType.Location = new System.Drawing.Point(340, 12);
            this.cbQuestionType.Name = "cbQuestionType";
            this.cbQuestionType.Size = new System.Drawing.Size(196, 24);
            this.cbQuestionType.TabIndex = 9;
            this.cbQuestionType.Text = "Loại Câu Hỏi";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChooseImage.Location = new System.Drawing.Point(60, 356);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(141, 44);
            this.btnChooseImage.TabIndex = 8;
            this.btnChooseImage.Text = "Chọn Ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pbQuestion
            // 
            this.pbQuestion.Location = new System.Drawing.Point(60, 89);
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.Size = new System.Drawing.Size(476, 261);
            this.pbQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion.TabIndex = 7;
            this.pbQuestion.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.Location = new System.Drawing.Point(297, 463);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(225, 51);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(60, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(231, 51);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbAddAnswer
            // 
            this.tbAddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddAnswer.Location = new System.Drawing.Point(60, 406);
            this.tbAddAnswer.Multiline = true;
            this.tbAddAnswer.Name = "tbAddAnswer";
            this.tbAddAnswer.Size = new System.Drawing.Size(462, 31);
            this.tbAddAnswer.TabIndex = 3;
            this.tbAddAnswer.Text = "Đáp Án";
            // 
            // tbAddQuestionName
            // 
            this.tbAddQuestionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddQuestionName.Location = new System.Drawing.Point(60, 52);
            this.tbAddQuestionName.Name = "tbAddQuestionName";
            this.tbAddQuestionName.Size = new System.Drawing.Size(462, 22);
            this.tbAddQuestionName.TabIndex = 1;
            this.tbAddQuestionName.Text = "Tên Câu Hỏi";
            // 
            // cbAddTopic
            // 
            this.cbAddTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddTopic.FormattingEnabled = true;
            this.cbAddTopic.Location = new System.Drawing.Point(60, 12);
            this.cbAddTopic.Name = "cbAddTopic";
            this.cbAddTopic.Size = new System.Drawing.Size(196, 24);
            this.cbAddTopic.TabIndex = 0;
            this.cbAddTopic.Text = "Bộ Đề";
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // ADM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 636);
            this.Controls.Add(this.panel1);
            this.Name = "ADM2";
            this.Text = "ADM.02_ThemCauHoi";
            this.Load += new System.EventHandler(this.ADM2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAddAnswer;
        private System.Windows.Forms.TextBox tbAddQuestionName;
        private System.Windows.Forms.ComboBox cbAddTopic;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbQuestion;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.ComboBox cbQuestionType;
    }
}