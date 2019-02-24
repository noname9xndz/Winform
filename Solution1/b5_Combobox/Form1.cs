using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b5_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DayDuLieuVaoCombobox();
        }
        public List<HocSinh> KhoiTaoDuLieu()
        {
            // cách 1 :
            //List<HocSinh> listHs = new List<HocSinh>();
            //HocSinh hs;
            //hs = new HocSinh();
            //hs.MaHS = "hs1";
            //hs.TenHS = "nguyễn trần minh";
            //listHs.Add(hs);

            // cách 2 nên viết
            List<HocSinh> listHs = new List<HocSinh>();
            listHs.Add(new HocSinh()
            {
                MaHS="hs1",TenHS="Nguyễn văn minh"
            });
            listHs.Add(new HocSinh() {MaHS = "hs2",TenHS = "Hà Văn Sơn"});
            listHs.Add(new HocSinh() { MaHS = "hs3", TenHS = "đặng hải triều" });
            return listHs;
        }
        public void DayDuLieuVaoCombobox()
        {
            // gán dữ liệu thể hiện trên combobox
            cboHocSinh.DataSource = KhoiTaoDuLieu();
            cboHocSinh.DisplayMember = "TenHS";
            cboHocSinh.ValueMember = "MaHS";
            // gán dữ liệu vô dropdown list(combobox khác style)
            DropDownListHocSinh.DataSource = KhoiTaoDuLieu();
            DropDownListHocSinh.DisplayMember = "TenHS";
            DropDownListHocSinh.ValueMember = "MaHS";
        }

        private void btnCombobox_Click(object sender, EventArgs e)
        {
            // lấy value
            string kq = "Mã Học Sinh" + cboHocSinh.SelectedValue + "-" + " Tên Học Sinh : " + cboHocSinh.Text + " STT"+cboHocSinh.SelectedIndex;
            MessageBox.Show(kq, "Kết quả chọn");
        }

        private void btnDropDownList_Click(object sender, EventArgs e)
        {
            string kq = "Mã Học Sinh " + DropDownListHocSinh.SelectedValue + "-" + " Tên Học Sinh : " + DropDownListHocSinh.Text;
            MessageBox.Show(kq, "Kết quả chọn");
        }
    }
}
