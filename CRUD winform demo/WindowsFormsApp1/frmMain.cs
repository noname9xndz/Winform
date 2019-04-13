using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa khoa = new frmKhoa();
            khoa.Show();
            
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien sinhVien = new frmSinhVien();
            frmMain frmMain = new frmMain();
            frmMain.Hide();
            sinhVien.Show();
            
        }
    }
}
