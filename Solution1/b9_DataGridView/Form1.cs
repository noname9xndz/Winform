using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b9_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddColumsDataGridView();
        }
        public void AddColumsDataGridView()
        {
            //Tạo các cột trên controldata GridView
            dgvSinhVien.Columns.Add("HoTen", "Họ tên");
            dgvSinhVien.Columns.Add("DiaChi", "Địa chỉ");
            dgvSinhVien.Columns.Add("Email", "Email");
            dgvSinhVien.Columns.Add("DienThoai", "Điện thoại");
        }

        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows != null)
            {
                // Lay dong duoc chon tren Datagridview
                DataGridViewRow dr = dgvSinhVien.SelectedRows[0];
                // Dien gia tri cua cac truong vao cac textbox tuong ung
                txtHoTen.Text = dr.Cells["HoTen"].Value.ToString();
                txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
                txtEmail.Text = dr.Cells["Email"].Value.ToString();
                txtSDT.Text = dr.Cells["DienThoai"].Value.ToString();
            }
        }
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            //Khai bao row,cells ( 1row là 1 dòng , 1 cell là 1 cột)
            DataGridViewRow row = new DataGridViewRow(); 
            DataGridViewCell _cell; 

            _cell = new DataGridViewTextBoxCell(); //Khai bao kieu cua cell
            _cell.Value = txtHoTen.Text; // gan gia tri Họ tên từ textbox
            row.Cells.Add(_cell); // add  cell vào row

            _cell = new DataGridViewTextBoxCell();
            _cell.Value = txtDiaChi.Text;
            row.Cells.Add(_cell); 

            _cell = new DataGridViewTextBoxCell();
            _cell.Value = txtEmail.Text;
            row.Cells.Add(_cell); 

            _cell = new DataGridViewTextBoxCell();
            _cell.Value = txtSDT.Text;
            row.Cells.Add(_cell); 

            dgvSinhVien.Rows.Add(row); // add row to datagridview
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows != null)
            {
                // Lay dong duoc chon tren Datagridview
                DataGridViewRow dr = dgvSinhVien.SelectedRows[0];
                // Dien gia tri cua cac truong vao cac textbox tuong ung
                dr.Cells["HoTen"].Value = txtHoTen.Text;
                dr.Cells["DiaChi"].Value = txtDiaChi.Text;
                dr.Cells["Email"].Value = txtEmail.Text;
                dr.Cells["DienThoai"].Value = txtSDT.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows != null)
            {
                // Lay dong duoc chon tren Datagridview
                DataGridViewRow dr = dgvSinhVien.SelectedRows[0];
                dgvSinhVien.Rows.Remove(dr);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
