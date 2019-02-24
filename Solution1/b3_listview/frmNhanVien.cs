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
    public partial class frmNhanVien : Form
    {
        public string MaNV
        {
            set { txtMaNV.Text = value; }
            get { return txtMaNV.Text; }
        }
        public string TenNV
        {
            set { txtTenNV.Text = value; }
            get { return txtTenNV.Text; }
        }
        public string LuongCB
        {
            set { TxtLuong.Text = value; }
            get { return TxtLuong.Text; }

        }

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
