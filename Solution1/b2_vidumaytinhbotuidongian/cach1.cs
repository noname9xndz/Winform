
using System;
using System.Windows.Forms;

namespace b2_vidumaytinhbotuidongian
{
    public partial class cach1 : Form
    {
        private string soHang1="";
        private string soHang2="";
        private string toanTu;
        private string ketQua;
        private bool chuyenSoHang = false;

        public cach1()
        {
            InitializeComponent();
        }

        #region  cách 1 đơn giản
        private void btnso0_Click(object sender, EventArgs e)
        {
            if (chuyenSoHang == false)
            {
                soHang1 += "0";
                txtketqua.Text = soHang1;
            }
            else
            {
                soHang2 += "0";
                txtketqua.Text = soHang2;
            }

        }

        private void btnso1_Click(object sender, EventArgs e)
        {
            if (chuyenSoHang == false)
            {
                soHang1 += "1";
                txtketqua.Text = soHang1;
            }
            else
            {
                soHang2 += "1";
                txtketqua.Text = soHang2;
            }
        }

        private void btnso2_Click(object sender, EventArgs e)
        {
            if (chuyenSoHang == false)
            {
                soHang1 += "2";
                txtketqua.Text = soHang1;
            }
            else
            {
                soHang2 += "2";
                txtketqua.Text = soHang2;
            }
        }

        private void btnso3_Click(object sender, EventArgs e)
        {
            if (chuyenSoHang == false)
            {
                soHang1 += "3";
                txtketqua.Text = soHang1;
            }
            else
            {
                soHang2 += "3";
                txtketqua.Text = soHang2;
            }
        }

        private void btnso4_Click(object sender, EventArgs e)
        {
            if (chuyenSoHang == false)
            {
                soHang1 += "4";
                txtketqua.Text = soHang1;
            }
            else
            {
                soHang2 += "4";
                txtketqua.Text = soHang2;
            }
        }

        private void btnso5_Click(object sender, EventArgs e)
        {
            if (chuyenSoHang == false)
            {
                soHang1 += "5";
                txtketqua.Text = soHang1;
            }
            else
            {
                soHang2 += "5";
                txtketqua.Text = soHang2;
            }
        }

        private void btnso6_Click(object sender, EventArgs e)
        {
            if (chuyenSoHang == false)
            {
                soHang1 += "6";
                txtketqua.Text = soHang1;
            }
            else
            {
                soHang2 += "6";
                txtketqua.Text = soHang2;
            }
        }

        private void btnso7_Click(object sender, EventArgs e)
        {
            if (chuyenSoHang == false)
            {
                soHang1 += "7";
                txtketqua.Text = soHang1;
            }
            else
            {
                soHang2 += "7";
                txtketqua.Text = soHang2;
            }
        }

        private void btnso8_Click(object sender, EventArgs e)
        {
            if (chuyenSoHang == false)
            {
                soHang1 += "8";
                txtketqua.Text = soHang1;
            }
            else
            {
                soHang2 += "8";
                txtketqua.Text = soHang2;
            }
        }

        private void btnso9_Click(object sender, EventArgs e)
        {
            if (chuyenSoHang == false)
            {
                soHang1 += "9";
                txtketqua.Text = soHang1;
            }
            else
            {
                soHang2 += "9";
                txtketqua.Text = soHang2;
            }
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            
            txtketqua.Text = "";
            //nhập số thứ 2 chuyển trạng thái
            chuyenSoHang = true;
            toanTu = "+";
        }

        private void btntru_Click(object sender, EventArgs e)
        {
           

            txtketqua.Text = "";
            chuyenSoHang = true;
            toanTu = "-";
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
           

            txtketqua.Text = "";
            chuyenSoHang = true;
            toanTu = "*";
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
           

            txtketqua.Text = "";
            chuyenSoHang = true;
            toanTu = "/";
        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            if (soHang2 == "")
            {
                soHang2 = "0";
            }

            switch (toanTu)
            {
                case "+":
                    {
                        ketQua = ( double.Parse(soHang1) + double.Parse(soHang2)).ToString();
                        soHang1 = "";
                        soHang2 = "";
                        chuyenSoHang = false;
                    };
                    break;
                case "-":
                    {
                        ketQua = (double.Parse(soHang1) - double.Parse(soHang2)).ToString();
                        soHang1 = "";
                        soHang2 = "";
                        chuyenSoHang = false;
                    };
                    break;
                case "*":
                    {
                        ketQua = (double.Parse(soHang1) * double.Parse(soHang2)).ToString();
                        soHang1 = "";
                        soHang2 = "";
                        chuyenSoHang = false;
                    };
                    break;
                case "/":
                    {
                        ketQua = (double.Parse(soHang1) / double.Parse(soHang2)).ToString();
                        soHang1 = "";
                        soHang2 = "";
                        chuyenSoHang = false;
                    };
                    break;
            }
            txtketqua.Text = ketQua;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
