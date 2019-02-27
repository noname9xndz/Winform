using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b7_QLSV_dongian
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            LoadDuLieuCombobox();
            KhoiTaoDuLieuListView();
        }
         
         public void KhoiTaoDuLieuListView()
         {
            lvSinhVien.Columns.Add( "Ma SV" );
            lvSinhVien.Columns.Add( "Họ Tên" );
            lvSinhVien.Columns.Add( "Ngày Sinh" );
            lvSinhVien.Columns.Add( "Giới Tính" );
            lvSinhVien.Columns.Add(" Mã Môn Học");
            lvSinhVien.Columns.Add( "Môn Học" );
            lvSinhVien.Columns.Add( "Học Phí" );

            lvSinhVien.View = View.Details;
          }
        public void LoadDuLieuCombobox()
        {
            cboMonHoc.DataSource = MonHoc.KhoiTaoDuLieu();
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";

            
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ép kiểu đối tượng xảy ra event
            ComboBox cboMH = (ComboBox)sender;
            // lấy giá trịn từ combobox
            MonHoc mh =(MonHoc) cboMH.SelectedItem;
            // lấy giá trị gán cho txtHocPhi
            txtHocPhi.Text = mh.HocPhi.ToString("#,##");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sMaSV = txtMaSV.Text;
            string sHoTen = txtTenSV.Text;
            string sMaMH = cboMonHoc.SelectedValue.ToString();
            string sTenMH = cboMonHoc.Text;
            string sHocPhi = txtHocPhi.Text;
            DateTime dtNgaySinh = dtpNgaySinh.Value;


            string sGioiTinh="";
            if(rdNam.Checked)
            {
                sGioiTinh = "Nam";

            }
            else
            {
                sGioiTinh = "Nữ";
            }

           

            // khơi tạo listviewitem

            ListViewItem listViewItem = new ListViewItem(sMaSV);
            listViewItem.SubItems.Add(sHoTen);
            listViewItem.SubItems.Add( dtNgaySinh.ToShortDateString() );
            listViewItem.SubItems.Add(sGioiTinh);
            listViewItem.SubItems.Add(sMaMH);
            listViewItem.SubItems.Add(sTenMH);
            listViewItem.SubItems.Add(sHocPhi);

            // add listviewitem vào list view
            //Mở thuộc tính hiển thị checkbox trên listview
            lvSinhVien.CheckBoxes = true;
            lvSinhVien.Items.Add(listViewItem);


        }
        

        private void lvSinhVien_Click(object sender, EventArgs e)
        {
            // gán dữ liệu được chọn lên control phía trên

            if(lvSinhVien.SelectedItems != null)
            {
                txtMaSV.Text = lvSinhVien.SelectedItems[0].SubItems[0].Text;
                txtTenSV.Text = lvSinhVien.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinh.Text = lvSinhVien.SelectedItems[0].SubItems[2].Text;
                cboMonHoc.SelectedValue = lvSinhVien.SelectedItems[0].SubItems[4].Text;
                txtHocPhi.Text = lvSinhVien.SelectedItems[0].SubItems[6].Text;
                if(lvSinhVien.SelectedItems[0].SubItems[3].Text == "Nam")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                 lvSinhVien.SelectedItems[0].SubItems[0].Text = txtMaSV.Text ;
               lvSinhVien.SelectedItems[0].SubItems[1].Text = txtTenSV.Text ;
                lvSinhVien.SelectedItems[0].SubItems[2].Text = dtpNgaySinh.Text;
                lvSinhVien.SelectedItems[0].SubItems[4].Text = cboMonHoc.SelectedValue.ToString() ;
                lvSinhVien.SelectedItems[0].SubItems[4].Text = cboMonHoc.Text;
                lvSinhVien.SelectedItems[0].SubItems[6].Text = txtHocPhi.Text ;
                if (rdNam.Checked == true)
                {

                    lvSinhVien.SelectedItems[0].SubItems[3].Text = "Nam";
                }
                else
                {
                    lvSinhVien.SelectedItems[0].SubItems[3].Text = "Nữ";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xóa 1 dòng như bình thường (Bài listView)
            //if (lvSinhVien.SelectedItems != null)
            //{
            //    lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
            //}


            //Xóa các dòng được chọn (Checked)
            if (lvSinhVien.CheckedItems.Count > 0)
            {
                ListView.CheckedListViewItemCollection lstChecked = lvSinhVien.CheckedItems;
                foreach (ListViewItem item in lstChecked)
                {
                    
                    MessageBox.Show(item.SubItems[6].Text);
                    // lvSinhVien.Items.Remove(item);
                }
            }
        }
    }
}
