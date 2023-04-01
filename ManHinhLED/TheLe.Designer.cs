namespace ManHinhLED
{
    partial class TheLe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuộc Thi Hán Ngữ Lần 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thể Lệ Cuộc Thi\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(539, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Có sẵn danh sách 5 bộ đề, mỗi bộ đề 10 câu.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(552, 64);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mỗi lần lên thi 1 nhóm 5 thí sinh thuộc 5 đội \r\nthi trên 5 máy tính.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(968, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bắt đầu thi MC sẽ bốc ngẫu nhiên 1 số thứ tự bộ đề và dùng cả bộ đề 10 câu đó.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(496, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mỗi câu hỏi sẽ có thời gian 10s để trả lời";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(836, 64);
            this.label7.TabIndex = 6;
            this.label7.Text = "Khi 5 đội làm bài xong sẽ tính điểm, nếu có cùng số điểm sẽ tính theo\r\nthời gian " +
    "làm bài";
            // 
            // TheLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 587);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TheLe";
            this.Text = "Thể Lệ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

