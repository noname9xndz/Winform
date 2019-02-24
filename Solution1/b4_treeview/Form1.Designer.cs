namespace b4_treeview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtDoiTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeviewConty = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnThemPB = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtDoiTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.treeviewConty);
            this.groupBox1.Controls.Add(this.btnThemPB);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Location = new System.Drawing.Point(32, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demo Tree view";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(405, 400);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 36);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtDoiTen
            // 
            this.txtDoiTen.Location = new System.Drawing.Point(101, 407);
            this.txtDoiTen.Name = "txtDoiTen";
            this.txtDoiTen.Size = new System.Drawing.Size(262, 22);
            this.txtDoiTen.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Đổi Tên";
            // 
            // treeviewConty
            // 
            this.treeviewConty.ImageIndex = 0;
            this.treeviewConty.ImageList = this.imageList1;
            this.treeviewConty.Location = new System.Drawing.Point(20, 27);
            this.treeviewConty.Name = "treeviewConty";
            this.treeviewConty.SelectedImageIndex = 0;
            this.treeviewConty.Size = new System.Drawing.Size(414, 354);
            this.treeviewConty.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_folder_299060.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_folder-open_1608888.png");
            this.imageList1.Images.SetKeyName(2, "iconfinder_icon-101-folder-search_314678.png");
            // 
            // btnThemPB
            // 
            this.btnThemPB.Location = new System.Drawing.Point(492, 45);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(80, 36);
            this.btnThemPB.TabIndex = 10;
            this.btnThemPB.Text = "Thêm PB";
            this.btnThemPB.UseVisualStyleBackColor = true;
            this.btnThemPB.Click += new System.EventHandler(this.btnThemPB_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(492, 111);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(80, 36);
            this.btnThemNV.TabIndex = 9;
            this.btnThemNV.Text = "Thêm NV";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(492, 318);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(80, 36);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(492, 252);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 36);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(492, 177);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(80, 36);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 485);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtDoiTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeviewConty;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.ImageList imageList1;
    }
}

