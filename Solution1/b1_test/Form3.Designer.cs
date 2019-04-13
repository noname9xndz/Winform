namespace b1_test
{
    partial class Form3
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
            this.btnXuatThongTin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.ckbDuLich = new System.Windows.Forms.CheckBox();
            this.ckbPhimAnh = new System.Windows.Forms.CheckBox();
            this.ckbTheThao = new System.Windows.Forms.CheckBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuatThongTin
            // 
            this.btnXuatThongTin.Location = new System.Drawing.Point(341, 229);
            this.btnXuatThongTin.Name = "btnXuatThongTin";
            this.btnXuatThongTin.Size = new System.Drawing.Size(218, 37);
            this.btnXuatThongTin.TabIndex = 5;
            this.btnXuatThongTin.Text = "Xuất Thông Tin";
            this.btnXuatThongTin.UseVisualStyleBackColor = true;
            this.btnXuatThongTin.Click += new System.EventHandler(this.btnXuatThongTin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.ckbDuLich);
            this.groupBox1.Controls.Add(this.ckbPhimAnh);
            this.groupBox1.Controls.Add(this.ckbTheThao);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 176);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(302, 34);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 22;
            // 
            // ckbDuLich
            // 
            this.ckbDuLich.AutoSize = true;
            this.ckbDuLich.Location = new System.Drawing.Point(393, 140);
            this.ckbDuLich.Name = "ckbDuLich";
            this.ckbDuLich.Size = new System.Drawing.Size(78, 21);
            this.ckbDuLich.TabIndex = 21;
            this.ckbDuLich.Text = "Du Lịch";
            this.ckbDuLich.UseVisualStyleBackColor = true;
            // 
            // ckbPhimAnh
            // 
            this.ckbPhimAnh.AutoSize = true;
            this.ckbPhimAnh.Location = new System.Drawing.Point(261, 140);
            this.ckbPhimAnh.Name = "ckbPhimAnh";
            this.ckbPhimAnh.Size = new System.Drawing.Size(90, 21);
            this.ckbPhimAnh.TabIndex = 20;
            this.ckbPhimAnh.Text = "Phim Ảnh";
            this.ckbPhimAnh.UseVisualStyleBackColor = true;
            this.ckbPhimAnh.CheckedChanged += new System.EventHandler(this.ckbPhimAnh_CheckedChanged);
            // 
            // ckbTheThao
            // 
            this.ckbTheThao.AutoSize = true;
            this.ckbTheThao.Location = new System.Drawing.Point(123, 140);
            this.ckbTheThao.Name = "ckbTheThao";
            this.ckbTheThao.Size = new System.Drawing.Size(92, 21);
            this.ckbTheThao.TabIndex = 19;
            this.ckbTheThao.Text = "Thể Thao";
            this.ckbTheThao.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(261, 93);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(47, 21);
            this.rdbNu.TabIndex = 18;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(123, 93);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 21);
            this.rdbNam.TabIndex = 17;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sở Thích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày Sinh";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(109, 34);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXuatThongTin);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXuatThongTin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox ckbDuLich;
        private System.Windows.Forms.CheckBox ckbPhimAnh;
        private System.Windows.Forms.CheckBox ckbTheThao;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
    }
}