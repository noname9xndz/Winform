using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b1_test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh;
            if (rdbNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            string Sothich = "";
            if(ckbDuLich.Checked)
            {
                Sothich += ckbDuLich.Text;
            }
            if (ckbPhimAnh.Checked)
            {
                Sothich += ckbPhimAnh.Text;
            }
            if (ckbTheThao.Checked)
            {
                Sothich += ckbTheThao.Text;
            }
            // string thongTin = "Họ Tên : " + ten + "ngày sinh : " + ngaySinh.ToString("dd/MM/yyyy") + "giới tính : " + gioiTinh + "Sở thích : " + Sothich;
            string thongTin = string.Format("Họ Tên : {0} , Ngày Sinh : {1} , Giới Tính : {2} ,Sở thích :{3} ",ten, ngaySinh.ToString("dd/MM/yyyy"), gioiTinh,Sothich);

            MessageBox.Show(thongTin, "tiêu đề : thông tin người dùng");
        }
    }
}
