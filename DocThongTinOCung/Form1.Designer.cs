namespace DocThongTinOCung
{
    partial class Form1
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
            this.btODia = new System.Windows.Forms.Button();
            this.btOCung = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btODia
            // 
            this.btODia.Location = new System.Drawing.Point(415, 276);
            this.btODia.Name = "btODia";
            this.btODia.Size = new System.Drawing.Size(153, 58);
            this.btODia.TabIndex = 0;
            this.btODia.Text = "Ổ Đĩa";
            this.btODia.UseVisualStyleBackColor = true;
            this.btODia.Click += new System.EventHandler(this.btODia_Click);
            // 
            // btOCung
            // 
            this.btOCung.Location = new System.Drawing.Point(200, 276);
            this.btOCung.Name = "btOCung";
            this.btOCung.Size = new System.Drawing.Size(153, 58);
            this.btOCung.TabIndex = 1;
            this.btOCung.Text = "Ổ cứng";
            this.btOCung.UseVisualStyleBackColor = true;
            this.btOCung.Click += new System.EventHandler(this.btOCung_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DocThongTinOCung.Properties.Resources.logo_k_cntt;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(5, 119);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(795, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐỀ TÀI : ĐỌC THÔNG TIN  CỦA Ổ CỨNG VÀ Ổ ĐĨA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "NHÓM : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trương Hùng Anh              16T1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nguyễn Quang Bảo          16T1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btOCung);
            this.Controls.Add(this.btODia);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btODia;
        private System.Windows.Forms.Button btOCung;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

