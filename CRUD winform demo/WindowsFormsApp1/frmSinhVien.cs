using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        #region register , clean 
        // sqlconnection giúp kết nối tới database
        private SqlConnection connection = new SqlConnection(@"Data Source = NONAME\NONAME;
Initial Catalog = svtest;Integrated Security = False;User Id = sa; Password=noname9xnd;MultipleActiveResultSets=True");
        // sql sqlcommand giúp thực thi câu lệnh sql
        private SqlDataAdapter sqlDataAdapter; // dùng cho dataset
        private SqlCommand sqlCommand; // dùng datatable
        // sqldatareader đọc dữ liệu từ sql
        private SqlDataReader sqlDataReader;
        // 
        private DataSet dataSet;
        private DataTable dataTable;



        private void ClearData()
        {
            txtMaSV.Text = txtTenSV.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            ckbGame.Checked = false;
            ckbMusic.Checked = false;
        }
        #endregion


        #region CRUDS

        public void HienThi()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            // khởi tạo truy vấn
            
            string query2 = "select * from tblKhoa";

            // dùng sqlcommand đê thực thi câu lệnh
            sqlCommand = new SqlCommand(query2, connection);
            // dùng sqldatareader để đọc dữ liệu trả về từ câu truy vấn
            sqlDataReader = sqlCommand.ExecuteReader(); // thực thi câu lệnh
           
            // đổ dữ liệu từ sql vào datatable
            dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            // đổ dữ liệu lên combox
            cboMaKhoa.DataSource = dataTable;

            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";

            string query = "select * from tblSinhVien";
            //c2 dùng sqlDataAdapter
            sqlDataAdapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "tblSinhVien");
            dgvSinhVien.DataSource = dataSet.Tables["tblSinhVien"];

            // rdNam.Checked = true;

            connection.Close();
        }

        private void AddParams()
        {
            sqlCommand.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
            sqlCommand.Parameters.AddWithValue("@MaKhoa", cboMaKhoa.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
            sqlCommand.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.ToShortDateString());


            bool GioiTinh = false;
            if (rdNam.Checked)
            {
                GioiTinh = true;
                //GioiTinh = "Nam";
            }
            if (rdNu.Checked)
            {
                GioiTinh = false;
                //GioiTinh = "Nữ";
            }
            sqlCommand.Parameters.AddWithValue("@GioiTinh", GioiTinh.ToString());

            string SoThich = "";
            if (ckbGame.Checked)
            {
                SoThich += ckbGame.Text + ",";
            }
            if (ckbMusic.Checked)
            {
                SoThich += ckbMusic.Text;
            }
            sqlCommand.Parameters.AddWithValue("@SoThich", SoThich.ToString());


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Length != 0)
            {
                if (checkKey() == false)
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    //string query2 = "select * from tblKhoa";

                    sqlCommand = new SqlCommand("insert into tblSinhVien(MaSV,MaKhoa,TenSV,NgaySinh,GioiTinh,SoThich) " +
                        "values(@MaSV,@MaKhoa,@TenSV,@NgaySinh,@GioiTinh,@SoThich)", connection);


                    // AddParams();

                    sqlCommand.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                    sqlCommand.Parameters.AddWithValue("@MaKhoa", cboMaKhoa.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@TenSV", txtTenSV.Text);

                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm Thành công");
                    HienThi();
                    ClearData();
                }
                else
                {
                    MessageBox.Show(" mã sinh viên đã bị trùng !!! nhập mã khác", "thông báo");
                }
            }
            else
            {
                MessageBox.Show("chưa nhập mã sinh viên", "thông báo");
            }


        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Length != 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                sqlCommand = new SqlCommand("update tblSinhVien set MaKhoa=@MaKhoa,TenSV=@TenSV,NgaySinh=@NgaySinh," +
                    "GioiTinh=@GioiTinh where MaSV=@MaSV", connection);

                AddParams();

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("sửa thành công");
                connection.Close();
                HienThi();
                txtMaSV.Enabled = true;
                ClearData();

            }
            else
            {
                MessageBox.Show("Chọn đối tượng cần sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows != null)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                sqlCommand = new SqlCommand("delete tblSinhVien where MaSV=@MaSV", connection);
                sqlCommand.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Xóa Thành Công");
                HienThi();
                txtMaSV.Enabled = true;
                ClearData();
            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng để xóa");
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            if (txtTimKiem.Text.Length != 0)
            {
                string query = "select * from tblSinhVien where MaSV LIKE N'%" + txtTimKiem.Text + "%' " +
                    "Or TenSV Like N'%" + txtTimKiem.Text + "%'";
                sqlDataAdapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Có " + dataTable.Rows.Count + " kết quả nào được tìm thấy với từ khóa : " 
                        + txtTimKiem.Text + "", "thông báo");
                    dgvSinhVien.DataSource = dataTable;
                    connection.Close();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Không có kết quả nào được tìm thấy với từ khóa : " + txtTimKiem.Text + "", "thông báo");
                }


            }
            else
            {
                MessageBox.Show("chưa nhập key", "thông báo");
                dataTable.Dispose();
                HienThi();
            }

        }


        #endregion

        #region check Key

        private bool checkKey()
        {
            bool key = false;
            string maSV = txtMaSV.Text;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            sqlDataAdapter = new SqlDataAdapter("Select MaSV from tblSinhVien where MaSV='" + maSV + "'", connection);
            
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                key = true;
            }
            dataTable.Dispose();
            return key;
        }

        private void checkKey2()
        {

            bool key = true;
            string maSV = txtMaSV.Text;
            string check = "Select Count(MaSV) from tblSinhVien s inner join tblKhoa k on s.MaKhoa = k.MaKhoa where s.MaKhoa ='" + maSV + "'";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            sqlDataAdapter = new SqlDataAdapter(check, connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                key = false;
            }
            dataTable.Dispose();
            //return key;

            string sothich1 = "Chơi Game,nghe nhạc";
            string sothich2 = "Chơi Game,";
            string sothich3 = "nghe nhạc";

            /*
             
                   select * from tblSinhVien

                   Select *
                   from tblSinhVien 
                   where MaSV ='gggg' and SoThich like 'C%c'

                   Select *
                   from tblSinhVien 
                   where MaSV ='SV02' and SoThich like '%c'

                   Select *
                   from tblSinhVien 
                   where MaSV ='SV01' and SoThich like 'C%,'
             */
        }

        #endregion


        #region click , doubleclick , refresh and close

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index <= dgvSinhVien.RowCount)
            {

                try
                {
                    txtMaSV.Enabled = false;
                    txtMaSV.Text = dgvSinhVien.Rows[index].Cells[0].Value.ToString();
                    cboMaKhoa.SelectedValue = dgvSinhVien.Rows[index].Cells[1].Value;
                    txtTenSV.Text = dgvSinhVien.Rows[index].Cells[2].Value.ToString();
                    dtpNgaySinh.Value = (DateTime)dgvSinhVien.Rows[index].Cells[3].Value;

                    if ((bool)dgvSinhVien.Rows[index].Cells[4].Value == true)
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("không có giá trị", "Thông báo");
                }

            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;//&& index <= dgvSinhVien.RowCount
            if (index >= 0 )
            {

                try
                {
                    txtMaSV.Enabled = false;
                    txtMaSV.Text = dgvSinhVien.Rows[index].Cells[0].Value.ToString();
                    cboMaKhoa.SelectedValue = dgvSinhVien.Rows[index].Cells[1].Value;
                    txtTenSV.Text = dgvSinhVien.Rows[index].Cells[2].Value.ToString();
                    dtpNgaySinh.Value = (DateTime)dgvSinhVien.Rows[index].Cells[3].Value;

                    if ((bool)dgvSinhVien.Rows[index].Cells[4].Value == true)
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("không có giá trị", "Thông báo");
                }


            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            HienThi();
            ClearData();
            txtMaSV.Enabled = true;
            ckbGame.Checked = false;
            ckbMusic.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        #endregion

        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            //int index = e.RowIndex;
            //if (index >= 0 && index <= dgvSinhVien.RowCount)
            //{

            //    try
            //    {
            //        txtMaSV.Enabled = false;
            //        txtMaSV.Text = dgvSinhVien.Rows[index].Cells[0].Value.ToString();
            //        cboMaKhoa.SelectedValue = dgvSinhVien.Rows[index].Cells[1].Value;
            //        txtTenSV.Text = dgvSinhVien.Rows[index].Cells[2].Value.ToString();
            //        dtpNgaySinh.Value = (DateTime)dgvSinhVien.Rows[index].Cells[3].Value;

            //        if ((bool)dgvSinhVien.Rows[index].Cells[4].Value == true)
            //        {
            //            rdNam.Checked = true;
            //        }
            //        else
            //        {
            //            rdNu.Checked = true;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("không có giá trị", "Thông báo");
            //    }

            //}
        }

        private void frmSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSinhVien frmSinhVien = new frmSinhVien();
            frmMain frmMain = new frmMain();
            frmSinhVien.Close();
            frmMain.Show();
        }
    }
}