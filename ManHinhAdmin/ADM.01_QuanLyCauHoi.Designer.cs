namespace ManHinhAdmin
{
    partial class ADM1
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXemCauHoi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteQ = new System.Windows.Forms.Button();
            this.btnEditQ = new System.Windows.Forms.Button();
            this.btnAddQ = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCauHoi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 618);
            this.panel1.TabIndex = 0;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(45, 84);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(138, 22);
            this.tbId.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.Controls.Add(this.btnXemCauHoi);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnDeleteQ);
            this.panel4.Controls.Add(this.btnEditQ);
            this.panel4.Controls.Add(this.btnAddQ);
            this.panel4.Location = new System.Drawing.Point(13, 501);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 100);
            this.panel4.TabIndex = 2;
            // 
            // btnXemCauHoi
            // 
            this.btnXemCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemCauHoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCauHoi.Location = new System.Drawing.Point(32, 29);
            this.btnXemCauHoi.Name = "btnXemCauHoi";
            this.btnXemCauHoi.Size = new System.Drawing.Size(161, 43);
            this.btnXemCauHoi.TabIndex = 16;
            this.btnXemCauHoi.Text = "Xem";
            this.btnXemCauHoi.UseVisualStyleBackColor = true;
            this.btnXemCauHoi.Click += new System.EventHandler(this.btnXemCauHoi_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(833, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 43);
            this.button2.TabIndex = 15;
            this.button2.Text = "Chia Đội";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteQ
            // 
            this.btnDeleteQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteQ.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteQ.Location = new System.Drawing.Point(432, 29);
            this.btnDeleteQ.Name = "btnDeleteQ";
            this.btnDeleteQ.Size = new System.Drawing.Size(161, 43);
            this.btnDeleteQ.TabIndex = 14;
            this.btnDeleteQ.Text = "Xóa";
            this.btnDeleteQ.UseVisualStyleBackColor = true;
            this.btnDeleteQ.Click += new System.EventHandler(this.btnDeleteQ_Click);
            // 
            // btnEditQ
            // 
            this.btnEditQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditQ.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQ.Location = new System.Drawing.Point(640, 29);
            this.btnEditQ.Name = "btnEditQ";
            this.btnEditQ.Size = new System.Drawing.Size(161, 43);
            this.btnEditQ.TabIndex = 13;
            this.btnEditQ.Text = "Xem Chi Tiết";
            this.btnEditQ.UseVisualStyleBackColor = true;
            this.btnEditQ.Click += new System.EventHandler(this.btnEditQ_Click);
            // 
            // btnAddQ
            // 
            this.btnAddQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQ.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQ.Location = new System.Drawing.Point(228, 29);
            this.btnAddQ.Name = "btnAddQ";
            this.btnAddQ.Size = new System.Drawing.Size(161, 43);
            this.btnAddQ.TabIndex = 11;
            this.btnAddQ.Text = "Thêm";
            this.btnAddQ.UseVisualStyleBackColor = true;
            this.btnAddQ.Click += new System.EventHandler(this.btnAddQ_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvCauHoi);
            this.panel3.Location = new System.Drawing.Point(13, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 352);
            this.panel3.TabIndex = 1;
            // 
            // dgvCauHoi
            // 
            this.dgvCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoi.Location = new System.Drawing.Point(32, 3);
            this.dgvCauHoi.Name = "dgvCauHoi";
            this.dgvCauHoi.RowHeadersWidth = 51;
            this.dgvCauHoi.RowTemplate.Height = 24;
            this.dgvCauHoi.Size = new System.Drawing.Size(993, 346);
            this.dgvCauHoi.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 65);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản Lí Trò Chơi Hán Ngữ";
            // 
            // ADM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 618);
            this.Controls.Add(this.panel1);
            this.Name = "ADM1";
            this.Text = "ADM.01_QuanLyCauHoi";
            this.Load += new System.EventHandler(this.ADM1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteQ;
        private System.Windows.Forms.Button btnEditQ;
        private System.Windows.Forms.Button btnXemCauHoi;
        private System.Windows.Forms.Button btnAddQ;
        private System.Windows.Forms.TextBox tbId;
        public System.Windows.Forms.DataGridView dgvCauHoi;
    }
}