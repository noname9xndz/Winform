using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b4_treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int MaPB = 0;
        public int MaNV = 0;

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            MaPB++;
            // them 1 node vào treeview

            // c1 : thêm trực tiếp 1 node con vào treeview (tên ,text,hình ảnh 0,hình ảnh 1 )
            // treeviewConty.Nodes.Add("PB" + MaPB, "Phòng ban" + MaPB,0,1);

            // c2 : hay sử dụng khởi tạo đối tượng treenode để add vào treeview

            TreeNode tnPhongBan = new TreeNode();
            tnPhongBan.Name = "MaPB" + MaPB;
            tnPhongBan.Text = "Phòng ban" + MaPB;
            tnPhongBan.ImageIndex = 0; // vị trí trong ImgList
            tnPhongBan.SelectedImageIndex = 1;// vị trí trong ImgList
            treeviewConty.Nodes.Add(tnPhongBan);

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            
            // selectedNode node đang được chon
            if(treeviewConty.SelectedNode !=null)
            {
                MaNV++;
                //2 cách thêm vào thư mục được trọn

                //c1 : 2 chính là vị trí imglist
                //treeviewConty.SelectedNode.Nodes.Add("MaNV"+MaNV,"Nhân Viên"+MaNV,2,2);

                //c2 : dùng tree node
                TreeNode tnNhanVien = new TreeNode();
                tnNhanVien.Name = "MaNV" + MaNV;
                tnNhanVien.Text = "Nhân Viên " + MaNV;
                tnNhanVien.ImageIndex = 2; 
                tnNhanVien.SelectedImageIndex = 2;
                treeviewConty.SelectedNode.Nodes.Add(tnNhanVien);
            }
        }



        private void btnsua_Click(object sender, EventArgs e)
        {
            if (treeviewConty.SelectedNode != null)
            {
                txtDoiTen.Text = treeviewConty.SelectedNode.Text;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (treeviewConty.SelectedNode != null)
            {
                treeviewConty.SelectedNode.Text = txtDoiTen.Text ;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (treeviewConty.SelectedNode != null)
            {
                treeviewConty.SelectedNode.Remove();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
