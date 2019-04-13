using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLSV.SinhVien
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        List<SinhVienDTO> listSV;
        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            rdNam.Checked = true;
            listSV = SinhVienBUL.LoadSinhVien();
            dgvSinhVien.DataSource = listSV;

            cboKhoa.DataSource = KhoaBUL.LoadKhoa();
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.DisplayMember = "TenKhoa";
            cleanData();
            SetDoRong();


        }
        
        #region thêm sửa xóa tìm kiếm

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVienDTO sinhVien = new SinhVienDTO
                {
                    MaSinhVien = txtMaSV.Text,
                    TenSV = txtTenSV.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    QueQuan = txtQueQuan.Text,
                    SDT = Convert.ToInt32(txtSDT.Text),
                    CMT = txtCMT.Text,
                    TenNguoiThan = txtTenNguoiThan.Text,
                    SDTNguoiThan = int.Parse(txtSDTNguoiThan.Text),
                    Hinh = "/Upload/avatar.jpg",
                    MaKhoa = cboKhoa.SelectedValue.ToString()
                };

                if (rdNam.Checked)
                {
                    sinhVien.GioiTinh = "Nam";
                }
                else
                {
                    sinhVien.GioiTinh = "Nữ";
                }

                if (SinhVienBUL.CheckSinhVien(sinhVien.MaSinhVien) == false && SinhVienBUL.ThemSinhVien(sinhVien) == true)
                {
                    //listSV.Add(sinhVien);
                    //dgvSinhVien.DataSource = typeof(List<SinhVienDTO>);
                    //dgvSinhVien.DataSource = listSV;


                    dgvSinhVien.DataSource = typeof(List<SinhVienDTO>);
                    dgvSinhVien.DataSource = SinhVienBUL.LoadSinhVien();
                    cleanData();

                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show(" Mã Sinh Viên Bị Trùng Thêm không thành công!", "Thông báo");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Xảy ra lỗi vui lòng thử lại!", "Thông báo");
                Validation();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                SinhVienDTO sinhVien = new SinhVienDTO
                {
                    MaSinhVien = txtMaSV.Text,
                    TenSV = txtTenSV.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    QueQuan = txtQueQuan.Text,
                    SDT = Convert.ToInt32(txtSDT.Text),
                    CMT = txtCMT.Text,
                    TenNguoiThan = txtTenNguoiThan.Text,
                    SDTNguoiThan = int.Parse(txtSDTNguoiThan.Text),
                    Hinh = "/Upload/avatar.jpg",
                    MaKhoa = cboKhoa.SelectedValue.ToString()
                };
                if (rdNam.Checked) 
                {
                    sinhVien.GioiTinh = "Nam";
                }
                else
                {
                    sinhVien.GioiTinh = "Nữ";
                }


                if (SinhVienBUL.SuaSinhVien(sinhVien) == true)
                {
                    //SinhVienDTO sinhVienSua = listSV.Single(x => x.MaSinhVien == sinhVien.MaSinhVien);
                    //sinhVienSua.MaSinhVien = txtMaSV.Text;
                    //sinhVienSua.TenSV = txtTenSV.Text;
                    //sinhVienSua.NgaySinh = dtpNgaySinh.Value;
                    //sinhVienSua.QueQuan = txtQueQuan.Text;
                    //sinhVienSua.SDT = Convert.ToInt32(txtSDT.Text);
                    //sinhVienSua.CMT = txtCMT.Text;
                    //sinhVienSua.TenNguoiThan = txtTenNguoiThan.Text;
                    //sinhVienSua.SDTNguoiThan = int.Parse(txtSDTNguoiThan.Text);
                    //sinhVienSua.Hinh = "/Upload/avatar.jpg";
                    //sinhVienSua.MaKhoa = cboKhoa.SelectedValue.ToString();
                    //dgvSinhVien.DataSource = typeof(List<SinhVienDTO>);
                    //dgvSinhVien.DataSource = listSV;
                    //cleanData();



                    dgvSinhVien.DataSource = typeof(List<SinhVienDTO>);
                    dgvSinhVien.DataSource = SinhVienBUL.LoadSinhVien();
                    cleanData();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Xảy ra lỗi vui lòng thử lại!", "Thông báo");
                Validation();
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text.ToString();
                if (SinhVienBUL.XoaSinhVien(maSV))
                {
                    //SinhVienDTO svDeleted = listSV.Single(n => n.MaSinhVien == maSV);
                    //listSV.Remove(svDeleted);
                    //dgvSinhVien.DataSource = typeof(List<SinhVienDTO>);
                    //dgvSinhVien.DataSource = listSV;


                    dgvSinhVien.DataSource = typeof(List<SinhVienDTO>);
                    dgvSinhVien.DataSource = SinhVienBUL.LoadSinhVien();
                    cleanData();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi !", "Thông báo");
            }
            

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (txtTimKiem.Text.Trim() == "")
            {
                cleanData();
                MessageBox.Show("Nhập vào từ khóa cần tìm");
            }
            else
            {
                List<SinhVienDTO> lstKetQuaTK = SinhVienBUL.TimSinhVien(txtTimKiem.Text);

                if (lstKetQuaTK != null)
                {
                    dgvSinhVien.DataSource = typeof(List<SinhVienDTO>);
                    dgvSinhVien.DataSource = lstKetQuaTK;
                    SetDoRong();
                    cleanData();
                    MessageBox.Show("Tìm thấy " + lstKetQuaTK.Count + " sinh viên ", "Thông báo!");
                }
                else
                {
                    cleanData();
                    MessageBox.Show("Không tìm thấy sinh viên", "Thông báo!");
                }
            }
        }


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            cleanData();
            SinhVienBUL.LoadSinhVien();
        }

        #endregion

        #region check lỗi
        private void SetDoRong()
        {
            //dgvSinhVien.Columns[0].Visible = false; // ẩn cột nếu cần
            dgvSinhVien.Columns[0].Width = 109;
            dgvSinhVien.Columns[1].Width = 109;
            dgvSinhVien.Columns[2].Width = 109;
            dgvSinhVien.Columns[3].Width = 109;
            dgvSinhVien.Columns[4].Width = 109;
            dgvSinhVien.Columns[5].Width = 109;
            dgvSinhVien.Columns[6].Width = 109;
            dgvSinhVien.Columns[7].Width = 109;
            dgvSinhVien.Columns[8].Width = 109;
            dgvSinhVien.Columns[9].Width = 109;
            dgvSinhVien.Columns[10].Width = 109;
        }


        private void cleanData()
        {
            dtpNgaySinh.Value = DateTime.Now;
            txtMaSV.Text = txtTenSV.Text = txtQueQuan.Text = txtCMT.Text = txtSDT.Text = txtTenNguoiThan.Text = txtSDTNguoiThan.Text= txtTimKiem.Text = "";
            txtMaSV.Enabled = true;
            btnThem.Enabled = true;

        }

        private void Validation()
        {
            if (txtMaSV.Text.Length == 0)
            {
                MessageBox.Show("Chưa Nhập Mã Sinh Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (txtSDT.Text.Length == 0)
            {
                MessageBox.Show("Chưa Nhập SDT!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (txtSDTNguoiThan.Text.Length == 0)
            {
                MessageBox.Show("Chưa Nhập SDT người thân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void txtSDTNguoiThan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }
        #endregion

       
        #region event datagirdview
        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    txtMaSV.Enabled = false;
                    btnThem.Enabled = false;
                    txtMaSV.Text = dgvSinhVien.Rows[index].Cells[0].Value.ToString();
                    txtTenSV.Text = dgvSinhVien.Rows[index].Cells[1].Value.ToString();
                    txtCMT.Text = dgvSinhVien.Rows[index].Cells[2].Value.ToString();
                    dtpNgaySinh.Value = (DateTime)dgvSinhVien.Rows[index].Cells[3].Value;
                    if (dgvSinhVien.Rows[index].Cells[4].ToString() == "Nam")
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                    txtQueQuan.Text = dgvSinhVien.Rows[index].Cells[5].Value.ToString();
                    txtSDT.Text = dgvSinhVien.Rows[index].Cells[6].Value.ToString();
                    txtTenNguoiThan.Text = dgvSinhVien.Rows[index].Cells[7].Value.ToString();
                    txtSDTNguoiThan.Text = dgvSinhVien.Rows[index].Cells[8].Value.ToString();
                    //txtHinh.Text = dgvSinhVien.Rows[index].Cells[9].Value.ToString();
                    cboKhoa.SelectedValue = dgvSinhVien.Rows[index].Cells[10].Value;

                }

                catch (Exception)
                {
                    MessageBox.Show("không có giá trị", "Thông báo");
                }

            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    txtMaSV.Enabled = false;
                    btnThem.Enabled = false;
                    txtMaSV.Text = dgvSinhVien.Rows[index].Cells[0].Value.ToString();
                    txtTenSV.Text = dgvSinhVien.Rows[index].Cells[1].Value.ToString();
                    txtCMT.Text = dgvSinhVien.Rows[index].Cells[2].Value.ToString();
                    dtpNgaySinh.Value = (DateTime)dgvSinhVien.Rows[index].Cells[3].Value;
                    if (dgvSinhVien.Rows[index].Cells[4].ToString() == "Nam")
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                    txtQueQuan.Text = dgvSinhVien.Rows[index].Cells[5].Value.ToString();
                    txtSDT.Text = dgvSinhVien.Rows[index].Cells[6].Value.ToString();
                    txtTenNguoiThan.Text = dgvSinhVien.Rows[index].Cells[7].Value.ToString();
                    txtSDTNguoiThan.Text = dgvSinhVien.Rows[index].Cells[8].Value.ToString();
                    //txtHinh.Text = dgvSinhVien.Rows[index].Cells[9].Value.ToString();
                    cboKhoa.SelectedValue = dgvSinhVien.Rows[index].Cells[10].Value;

                }

                catch (Exception)
                {
                    MessageBox.Show("không có giá trị", "Thông báo");
                }

            }
        }

        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            //Kiểm tra dòng được chọn
            if (dgvSinhVien.SelectedRows != null)
            {
                try
                {
                    txtMaSV.Enabled = false;
                    btnThem.Enabled = false;
                    //Lấy ra dòng được chọn gán vào các control phía trên
                    DataGridViewRow dataGridViewRow = dgvSinhVien.SelectedRows[0];
                    txtMaSV.Text = dataGridViewRow.Cells["MaSinhVien"].Value.ToString();
                    txtTenSV.Text = dataGridViewRow.Cells["TenSV"].Value.ToString();
                    txtQueQuan.Text = dataGridViewRow.Cells["QueQuan"].Value.ToString();
                    txtSDT.Text = dataGridViewRow.Cells["SDT"].Value.ToString();
                    txtTenNguoiThan.Text = dataGridViewRow.Cells["TenNguoiThan"].Value.ToString();
                    txtSDTNguoiThan.Text = dataGridViewRow.Cells["SDTNguoiThan"].Value.ToString();
                    txtCMT.Text = dataGridViewRow.Cells["CMT"].Value.ToString();
                    cboKhoa.SelectedValue = dataGridViewRow.Cells["MaKhoa"].Value;
                    dtpNgaySinh.Value = (DateTime)dataGridViewRow.Cells["NgaySinh"].Value;
                    if (dataGridViewRow.Cells["GioiTinh"].ToString() == "Nam")
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }

                    //if ((bool)dr.Cells["GioiTinh"].Value == true)
                    //{
                    //    rdbNam.Checked = true;
                    //}
                    //else
                    //{
                    //    rdbNu.Checked = true;
                    //}
                }
                catch (Exception)
                {

                }

            }
           
        }

       
        #endregion

        /*


private void btnThem_Click(object sender, EventArgs e)
{

//Bước 1: Lấy giá trị từ các control giao diện gán vào đối tượng NHANVIEN_DTO
NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
nvDTO.HoTen = txtHoTen.Text;
if (rdbNam.Checked)
nvDTO.GioiTinh = true;
else
nvDTO.GioiTinh = false;
nvDTO.NgaySinh = dtpNgaySinh.Value;
nvDTO.DiaChi = txtDiaChi.Text;
nvDTO.MaTrinhDo = Convert.ToInt32(cmbTrinhDo.SelectedValue);
nvDTO.DienThoai = txtDienThoai.Text;

//Bước 2: Gọi nghiệp vụ thêm nhân viên
//Kiểm tra xem đã thêm vào csdl được hay chưa
if (NHANVIEN_BUL.ThemNhanVien(nvDTO) == true)
{
lstNhanVien.Add(nvDTO);
//Định dạng lại datasource của datagridview
//dgvNhanVien.DataSource = typeof(List<NHANVIEN_DTO>);
//dgvNhanVien.DataSource = lstNhanVien;

////Ẩn cột nhân viên
//dgvNhanVien.Columns[0].Visible = false;
LoadDgvNhanVien();
MessageBox.Show("Thêm thành công!", "Thông báo");
}
else
{
MessageBox.Show("Thêm không thành công!", "Thông báo");
}


}

private void dgvNhanVien_Click(object sender, EventArgs e)
{
//Kiểm tra dòng được chọn
if (dgvNhanVien.SelectedRows != null)
{
//Lấy ra dòng được chọn gán vào các control phía trên
DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
lblMaNV.Text = dr.Cells["MaNV"].Value.ToString();
txtHoTen.Text = dr.Cells["HoTen"].Value.ToString();
txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
txtDienThoai.Text = dr.Cells["DienThoai"].Value.ToString();
cmbTrinhDo.SelectedValue = dr.Cells["MaTrinhDo"].Value;
dtpNgaySinh.Value = (DateTime)dr.Cells["NgaySinh"].Value;
if ((bool)dr.Cells["GioiTinh"].Value == true)
{
rdbNam.Checked = true;
}
else
{
rdbNu.Checked = true;
}
}
}

private void btnSua_Click(object sender, EventArgs e)
{


private void btnXoa_Click(object sender, EventArgs e)
{
int maNV = Convert.ToInt32(lblMaNV.Text);
if (NHANVIEN_BUL.XoaNhanVien(maNV))
{
//Load lại control datagridview
NHANVIEN_DTO nvDeleted = lstNhanVien.Single(n => n.MaNV == maNV);
lstNhanVien.Remove(nvDeleted);
LoadDgvNhanVien();
MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
}
else
{
MessageBox.Show("Xóa không thành công!", "Thông báo");
}
}
public void LoadDgvNhanVien()
{
dgvNhanVien.DataSource = typeof(List<NHANVIEN_DTO>);
dgvNhanVien.DataSource = lstNhanVien;
dgvNhanVien.Columns[0].Visible = false;
SetDoRongCot();
}


private void btnTimKiem_Click(object sender, EventArgs e)
{

}

}

*/
    }
}
