using b5_Combobox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b6_ListBox
{
    public partial class btnDongY : Form
    {
        public btnDongY()
        {
            InitializeComponent();
            DayDuLieuVaoListBox();
        }
        public List<HocSinh> KhoiTaoDuLieu()
        {
            List<HocSinh> listHs = new List<HocSinh>();
            listHs.Add(new HocSinh()
            {
                MaHS = "hs1",
                TenHS = "Nguyễn văn minh"
            });
            listHs.Add(new HocSinh() { MaHS = "hs2", TenHS = "Hà Văn Sơn" });
            listHs.Add(new HocSinh() { MaHS = "hs3", TenHS = "đặng hải triều1" });
            listHs.Add(new HocSinh() { MaHS = "hs4", TenHS = "đặng hải triều2" });
            listHs.Add(new HocSinh() { MaHS = "hs5", TenHS = "đặng hải triều3" });
            listHs.Add(new HocSinh() { MaHS = "hs6", TenHS = "đặng hải triều4" });
            listHs.Add(new HocSinh() { MaHS = "hs7", TenHS = "đặng hải triều5" });
            listHs.Add(new HocSinh() { MaHS = "hs8", TenHS = "đặng hải triều6" });
            listHs.Add(new HocSinh() { MaHS = "hs9", TenHS = "đặng hải triều7" });

            return listHs;
        }
        public void DayDuLieuVaoListBox()
        {
            // gán dữ liệu thể hiện trên combobox
            listBoxHocSinh.DataSource = KhoiTaoDuLieu();
            listBoxHocSinh.DisplayMember = "TenHS";
            listBoxHocSinh.ValueMember = "MaHS";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "";
            if(listBoxHocSinh.SelectedItems.Count>0)
            {
                foreach(HocSinh item in listBoxHocSinh.SelectedItems)
                {
                    lblKetQua.Text += "Mã HS : " + item.MaHS + " Tên HS : " + item.TenHS + "\n";
                }
            }
        }
    }
}
