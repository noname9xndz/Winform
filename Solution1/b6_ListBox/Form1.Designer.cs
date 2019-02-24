namespace b6_ListBox
{
    partial class btnDongY
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
            this.listBoxHocSinh = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxHocSinh
            // 
            this.listBoxHocSinh.FormattingEnabled = true;
            this.listBoxHocSinh.ItemHeight = 16;
            this.listBoxHocSinh.Location = new System.Drawing.Point(28, 21);
            this.listBoxHocSinh.MultiColumn = true;
            this.listBoxHocSinh.Name = "listBoxHocSinh";
            this.listBoxHocSinh.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxHocSinh.Size = new System.Drawing.Size(282, 276);
            this.listBoxHocSinh.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đồng Ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giá Trị Được Chọn : ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(362, 76);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(70, 17);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "lblKetQua";
            // 
            // btnDongY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 444);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxHocSinh);
            this.Name = "btnDongY";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHocSinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKetQua;
    }
}

