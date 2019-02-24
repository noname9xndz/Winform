using System;
using System.Windows.Forms;

namespace b2_vidumaytinhbotuidongian
{
    public partial class Form1 : Form
    {
        
        private string toanTu="";
        private double ketQua;
        private bool chuyenSoHang = true;

        public Form1()
        {
            InitializeComponent();
            XuLy();
        }

        #region  cách 2 

        void NhapSo(object obj,EventArgs args)
        {
            // ép kiểu obj truyền vào thành button
            int soHang = int.Parse( ((Button)obj).Text );

            if (chuyenSoHang == true)
            {
                txtketqua.Text = "";
                txtketqua.Text += soHang.ToString();
                chuyenSoHang = false;

            }
        }
        void XuLy()
        {
            // khai báo event click
            this.btnso0.Click += new EventHandler(this.NhapSo);
            this.btnso1.Click += new EventHandler(this.NhapSo);
            this.btnso2.Click += new EventHandler(this.NhapSo);
            this.btnso3.Click += new EventHandler(this.NhapSo);
            this.btnso4.Click += new EventHandler(this.NhapSo);
            this.btnso5.Click += new EventHandler(this.NhapSo);
            this.btnso6.Click += new EventHandler(this.NhapSo);
            this.btnso7.Click += new EventHandler(this.NhapSo);
            this.btnso8.Click += new EventHandler(this.NhapSo);
            this.btnso9.Click += new EventHandler(this.NhapSo);


            this.btncong.Click += new EventHandler(this.NhapToanTu);
            this.btntru.Click += new EventHandler(this.NhapToanTu);
            this.btnnhan.Click += new EventHandler(this.NhapToanTu);
            this.btnchia.Click += new EventHandler(this.NhapToanTu);

            this.btnbang.Click += new EventHandler(this.TinhToan);
        }
        void NhapToanTu(object obj,EventArgs args)
        {
            toanTu = ((Button)obj).Text;
            
           // ketQua =double.Parse(txtketqua.Text);
            switch (toanTu)
            {
                case "+":{ ketQua  += double.Parse(txtketqua.Text);}; break;
                case "-":{ ketQua  -= double.Parse(txtketqua.Text);}; break;
                case "*":{ ketQua  *= double.Parse(txtketqua.Text);}; break;
                case "/":{ ketQua  /= double.Parse(txtketqua.Text);}; break;
            }
            chuyenSoHang = true;

        }
        void TinhToan(object obj,EventArgs args)
        {
            switch(toanTu)
            {
                case "+":
                    {
                        ketQua += double.Parse(txtketqua.Text);
                    };break;
                case "-":
                    {
                        ketQua -= double.Parse(txtketqua.Text);
                    };break;
                case "*":
                    {
                        ketQua *= double.Parse(txtketqua.Text);
                    };break;
                case "/":
                    {
                        ketQua /= double.Parse(txtketqua.Text);
                    };break;
                case "":
                    {
                        ketQua = double.Parse(txtketqua.Text);
                    };break;
            }
            txtketqua.Text =ketQua.ToString();
            chuyenSoHang = true;
        }


        #endregion
        
    }
}
