namespace DocThongTinOCung
{
    partial class ODia
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
            this.cbbODia = new System.Windows.Forms.ComboBox();
            this.lbNameODia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbChiTiet = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNamePhanVung = new System.Windows.Forms.TextBox();
            this.tbDinhDang = new System.Windows.Forms.TextBox();
            this.tbSectorsCluster = new System.Windows.Forms.TextBox();
            this.tbSerialPV = new System.Windows.Forms.TextBox();
            this.tbDungLuongTrong = new System.Windows.Forms.TextBox();
            this.tbDungLuongDung = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCluster = new System.Windows.Forms.TextBox();
            this.tbTongDungLuong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "chọn ổ đĩa";
            // 
            // cbbODia
            // 
            this.cbbODia.FormattingEnabled = true;
            this.cbbODia.Location = new System.Drawing.Point(297, 16);
            this.cbbODia.Name = "cbbODia";
            this.cbbODia.Size = new System.Drawing.Size(200, 21);
            this.cbbODia.TabIndex = 1;
            this.cbbODia.SelectedIndexChanged += new System.EventHandler(this.cbbODia_SelectedIndexChanged);
            // 
            // lbNameODia
            // 
            this.lbNameODia.Location = new System.Drawing.Point(294, 60);
            this.lbNameODia.Name = "lbNameODia";
            this.lbNameODia.Size = new System.Drawing.Size(203, 13);
            this.lbNameODia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Image = global::DocThongTinOCung.Properties.Resources.disk_manager_icon;
            this.label3.Location = new System.Drawing.Point(149, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 118);
            this.label3.TabIndex = 3;
            // 
            // lbChiTiet
            // 
            this.lbChiTiet.Location = new System.Drawing.Point(294, 126);
            this.lbChiTiet.Name = "lbChiTiet";
            this.lbChiTiet.Size = new System.Drawing.Size(203, 13);
            this.lbChiTiet.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(297, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(44, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Phân vùng";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(45, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Định dang";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(44, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "số Sectors/Cluster";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(438, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 41);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số Serial phân vùng";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(438, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "dung lượng còn trống";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(438, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Dung lượng đã dùng";
            // 
            // tbNamePhanVung
            // 
            this.tbNamePhanVung.Location = new System.Drawing.Point(177, 195);
            this.tbNamePhanVung.Name = "tbNamePhanVung";
            this.tbNamePhanVung.Size = new System.Drawing.Size(200, 20);
            this.tbNamePhanVung.TabIndex = 12;
            this.tbNamePhanVung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDinhDang
            // 
            this.tbDinhDang.Location = new System.Drawing.Point(177, 248);
            this.tbDinhDang.Name = "tbDinhDang";
            this.tbDinhDang.Size = new System.Drawing.Size(200, 20);
            this.tbDinhDang.TabIndex = 13;
            this.tbDinhDang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSectorsCluster
            // 
            this.tbSectorsCluster.Location = new System.Drawing.Point(177, 309);
            this.tbSectorsCluster.Name = "tbSectorsCluster";
            this.tbSectorsCluster.Size = new System.Drawing.Size(200, 20);
            this.tbSectorsCluster.TabIndex = 14;
            this.tbSectorsCluster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSerialPV
            // 
            this.tbSerialPV.Location = new System.Drawing.Point(549, 192);
            this.tbSerialPV.Name = "tbSerialPV";
            this.tbSerialPV.Size = new System.Drawing.Size(200, 20);
            this.tbSerialPV.TabIndex = 15;
            this.tbSerialPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDungLuongTrong
            // 
            this.tbDungLuongTrong.Location = new System.Drawing.Point(549, 255);
            this.tbDungLuongTrong.Name = "tbDungLuongTrong";
            this.tbDungLuongTrong.Size = new System.Drawing.Size(200, 20);
            this.tbDungLuongTrong.TabIndex = 16;
            this.tbDungLuongTrong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDungLuongDung
            // 
            this.tbDungLuongDung.Location = new System.Drawing.Point(549, 312);
            this.tbDungLuongDung.Name = "tbDungLuongDung";
            this.tbDungLuongDung.Size = new System.Drawing.Size(200, 20);
            this.tbDungLuongDung.TabIndex = 17;
            this.tbDungLuongDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(438, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tổng dung lượng";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(45, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tổng số CLuster";
            // 
            // tbCluster
            // 
            this.tbCluster.Location = new System.Drawing.Point(177, 365);
            this.tbCluster.Name = "tbCluster";
            this.tbCluster.Size = new System.Drawing.Size(200, 20);
            this.tbCluster.TabIndex = 20;
            this.tbCluster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTongDungLuong
            // 
            this.tbTongDungLuong.Location = new System.Drawing.Point(549, 361);
            this.tbTongDungLuong.Name = "tbTongDungLuong";
            this.tbTongDungLuong.Size = new System.Drawing.Size(200, 20);
            this.tbTongDungLuong.TabIndex = 21;
            this.tbTongDungLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ODia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTongDungLuong);
            this.Controls.Add(this.tbCluster);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbDungLuongDung);
            this.Controls.Add(this.tbDungLuongTrong);
            this.Controls.Add(this.tbSerialPV);
            this.Controls.Add(this.tbSectorsCluster);
            this.Controls.Add(this.tbDinhDang);
            this.Controls.Add(this.tbNamePhanVung);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbChiTiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNameODia);
            this.Controls.Add(this.cbbODia);
            this.Controls.Add(this.label1);
            this.Name = "ODia";
            this.Text = "thông tin ổ đĩa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ODia_FormClosed);
            this.Load += new System.EventHandler(this.ODia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbODia;
        private System.Windows.Forms.Label lbNameODia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbChiTiet;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNamePhanVung;
        private System.Windows.Forms.TextBox tbDinhDang;
        private System.Windows.Forms.TextBox tbSectorsCluster;
        private System.Windows.Forms.TextBox tbSerialPV;
        private System.Windows.Forms.TextBox tbDungLuongTrong;
        private System.Windows.Forms.TextBox tbDungLuongDung;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCluster;
        private System.Windows.Forms.TextBox tbTongDungLuong;
    }
}