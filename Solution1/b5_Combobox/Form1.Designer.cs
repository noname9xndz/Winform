namespace b5_Combobox
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
            this.cboHocSinh = new System.Windows.Forms.ComboBox();
            this.DropDownListHocSinh = new System.Windows.Forms.ComboBox();
            this.btnCombobox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDropDownList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboHocSinh
            // 
            this.cboHocSinh.FormattingEnabled = true;
            this.cboHocSinh.Location = new System.Drawing.Point(59, 66);
            this.cboHocSinh.Name = "cboHocSinh";
            this.cboHocSinh.Size = new System.Drawing.Size(249, 24);
            this.cboHocSinh.TabIndex = 0;
            // 
            // DropDownListHocSinh
            // 
            this.DropDownListHocSinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownListHocSinh.FormattingEnabled = true;
            this.DropDownListHocSinh.Location = new System.Drawing.Point(59, 158);
            this.DropDownListHocSinh.Name = "DropDownListHocSinh";
            this.DropDownListHocSinh.Size = new System.Drawing.Size(249, 24);
            this.DropDownListHocSinh.TabIndex = 1;
            // 
            // btnCombobox
            // 
            this.btnCombobox.Location = new System.Drawing.Point(370, 60);
            this.btnCombobox.Name = "btnCombobox";
            this.btnCombobox.Size = new System.Drawing.Size(106, 34);
            this.btnCombobox.TabIndex = 2;
            this.btnCombobox.Text = "Xuất Kết Quả";
            this.btnCombobox.UseVisualStyleBackColor = true;
            this.btnCombobox.Click += new System.EventHandler(this.btnCombobox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Combobox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Drop Down List";
            // 
            // btnDropDownList
            // 
            this.btnDropDownList.Location = new System.Drawing.Point(370, 152);
            this.btnDropDownList.Name = "btnDropDownList";
            this.btnDropDownList.Size = new System.Drawing.Size(106, 34);
            this.btnDropDownList.TabIndex = 6;
            this.btnDropDownList.Text = "Xuất Kết Quả";
            this.btnDropDownList.UseVisualStyleBackColor = true;
            this.btnDropDownList.Click += new System.EventHandler(this.btnDropDownList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 285);
            this.Controls.Add(this.btnDropDownList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCombobox);
            this.Controls.Add(this.DropDownListHocSinh);
            this.Controls.Add(this.cboHocSinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHocSinh;
        private System.Windows.Forms.ComboBox DropDownListHocSinh;
        private System.Windows.Forms.Button btnCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDropDownList;
    }
}

