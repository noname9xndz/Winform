using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b3_listview
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        
        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // tên colums , độ rộng
            lvNhanVien.Columns.Add("MaNV", 80);
            lvNhanVien.Columns.Add("Ten NV", 114);
            lvNhanVien.Columns.Add("Lương CB", 129);
            // hiển thị columns ra view
            lvNhanVien.View = View.Details;
        }

       

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
           // frmNhanVien.ShowDialog(); // hiển thị form 2 ra

            // khi form 2 bấm oke
            if(frmNhanVien.ShowDialog()== DialogResult.OK)
            {
                ListViewItem listViewItem = new ListViewItem(frmNhanVien.MaNV);
             // mỗi SubItems tương ứng với 1 cột
                listViewItem.SubItems.Add(frmNhanVien.TenNV);
                listViewItem.SubItems.Add(frmNhanVien.LuongCB);

                // thêm listviewitems và listview
                lvNhanVien.Items.Add(listViewItem);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // lấy giá trị dòng được chọn
            frmNhanVien frmNhanVien = new frmNhanVien();

            if (lvNhanVien.SelectedItems.Count > 0)
            {  // mỗi SubItems tương ứng với 1 cột
               // SelectedItems[0] lấy ra ptu đầu tiên được chọn (khi ctrl có thể chọn 2 item trở lên, ta lấy item đầu )
                frmNhanVien.MaNV = lvNhanVien.SelectedItems[0].SubItems[0].Text;
                frmNhanVien.TenNV = lvNhanVien.SelectedItems[0].SubItems[1].Text;
                frmNhanVien.LuongCB = lvNhanVien.SelectedItems[0].SubItems[2].Text;

                if (frmNhanVien.ShowDialog() == DialogResult.OK)
                {
                    lvNhanVien.SelectedItems[0].SubItems[0].Text = frmNhanVien.MaNV;
                    lvNhanVien.SelectedItems[0].SubItems[1].Text = frmNhanVien.TenNV;
                    lvNhanVien.SelectedItems[0].SubItems[2].Text = frmNhanVien.LuongCB;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (lvNhanVien.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa mã nhân viên " + lvNhanVien.SelectedItems[0].SubItems[0].Text,
                                     "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes    )
                {
                    lvNhanVien.Items.Remove(lvNhanVien.SelectedItems[0]);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
