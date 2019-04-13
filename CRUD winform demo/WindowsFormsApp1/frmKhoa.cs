using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();

        }


        SqlConnection connection = new SqlConnection(@"Data Source = NONAME\NONAME;Initial Catalog = svtest;
Integrated Security = False;User Id = sa; Password=noname9xnd;MultipleActiveResultSets=True");
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        SqlCommand sqlCommand;



        private void frmKhoa_Load(object sender, EventArgs e)
        {

            AddColumsDataGridView();
            HienThi();

        }

        public void AddColumsDataGridView()
        {
            //Tạo các cột trên controldata GridView
            dgvKhoa.Columns.Add("MaKhoa", "Họ tên");
            dgvKhoa.Columns.Add("TenKhoa", "Tên Khoa");
            dgvKhoa.Columns.Add("Email", "Email");
            dgvKhoa.Columns.Add("SDT", "Điện Thoại");
            dgvKhoa.Columns.Add("DiaChi", "Địa Chỉ");

        }

        public void HienThi()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string query = "select * from tblKhoa";
            sqlDataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvKhoa.DataSource = dataTable;
            connection.Close();
        }
        private void ClearData()
        {
            txtMaKhoa.Text = txtTenKhoa.Text = txtDiaChi.Text = txtEmail.Text = txtEmail.Text = txtSDT.Text = "";
            dtpNgayThanhLap.Value = DateTime.Now;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (connection.State == ConnectionState.Closed)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            if (txtTimKiem.Text.Length != 0)
            {
                string query = "select * from tblKhoa where MaKhoa LIKE N'%" + txtTimKiem.Text + "%' " +
                    "Or TenKhoa Like N'%" + txtTimKiem.Text + "%'";
                sqlDataAdapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvKhoa.DataSource = dataTable;
                connection.Close();
                ClearData();
            }
            else
            {
                MessageBox.Show("chưa nhập key", "thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtMaKhoa.Text.Length != 0)
            {
                if (checkKey() == false)
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                    }
                    txtMaKhoa.Enabled = true;
                    sqlCommand = new SqlCommand("insert into tblKhoa(MaKhoa,TenKhoa,DiaChi,Email,SDT,NgayThanhLap) " +
                        "values(@MaKhoa,@TenKhoa,@DiaChi,@Email,@SDT,@NgayThanhLap)", connection);
                    sqlCommand.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                    sqlCommand.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text);
                    sqlCommand.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    sqlCommand.Parameters.AddWithValue("@NgayThanhLap", dtpNgayThanhLap.Value.ToShortDateString());
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm Thành công");
                    HienThi();
                    ClearData();
                }
                else
                {
                    MessageBox.Show(" mã khoa đã bị trùng !!! nhập mã khác", "thông báo");
                }

            }
            else
            {
                MessageBox.Show("chưa nhập mã khoa", "thông báo");
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows != null)
            {
                if (checkKey2())
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    sqlCommand = new SqlCommand("delete tblKhoa where MaKhoa=@MaKhoa", connection);
                    sqlCommand.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Xóa Thành Công");
                    HienThi();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Yêu cầu xóa hết sinh viên trong khoa hoặc chuyển sinh viên sang khoa khác , " +
                        "trước khi xóa khoa", "Thông Báo");
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng để xóa", "Thông Báo");
            }
        }




        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Length != 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                sqlCommand = new SqlCommand("update tblKhoa set TenKhoa=@TenKhoa,DiaChi=@DiaChi,Email=@Email," +
                    "SDT=@SDT,NgayThanhLap=@NgayThanhLap where MaKhoa=@MaKhoa", connection);

                sqlCommand.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                sqlCommand.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text);
                sqlCommand.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                sqlCommand.Parameters.AddWithValue("@SDT", txtSDT.Text);
                sqlCommand.Parameters.AddWithValue("@NgayThanhLap", dtpNgayThanhLap.Value.ToShortDateString());

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("sửa thành công");
                connection.Close();
                HienThi();
                txtMaKhoa.Enabled = true;
                ClearData();

            }
            else
            {
                MessageBox.Show("Chọn đối tượng cần sửa");
            }
        }
        private bool checkKey()
        {
            bool key = false;
            string maKhoa = txtMaKhoa.Text;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            sqlDataAdapter = new SqlDataAdapter("Select MaKhoa from tblKhoa where MaKhoa='" + maKhoa + "'", connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                key = true;
            }
            dataTable.Dispose();
            return key;
        }

        private bool checkKey2()
        {

            bool key = true;
            string maKhoa = txtMaKhoa.Text;
            string check = "Select Count(MaSV) from tblSinhVien s inner join tblKhoa k on s.MaKhoa = k.MaKhoa" +
                " where s.MaKhoa ='" + maKhoa + "'";
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
            return key;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    txtMaKhoa.Enabled = false;
                    txtMaKhoa.Text = dgvKhoa.Rows[index].Cells[0].Value.ToString();
                    txtTenKhoa.Text = dgvKhoa.Rows[index].Cells[1].Value.ToString();
                    txtDiaChi.Text = dgvKhoa.Rows[index].Cells[2].Value.ToString();
                    txtEmail.Text = dgvKhoa.Rows[index].Cells[3].Value.ToString();
                    txtSDT.Text = dgvKhoa.Rows[index].Cells[4].Value.ToString();
                    dtpNgayThanhLap.Value = (DateTime)dgvKhoa.Rows[index].Cells[5].Value;
                }

                catch (Exception)
                {
                    MessageBox.Show("không có giá trị", "Thông báo");
                }

            }

        }
        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    txtMaKhoa.Enabled = false;
                    txtMaKhoa.Text = dgvKhoa.Rows[index].Cells[0].Value.ToString();
                    txtTenKhoa.Text = dgvKhoa.Rows[index].Cells[1].Value.ToString();
                    txtDiaChi.Text = dgvKhoa.Rows[index].Cells[2].Value.ToString();
                    txtEmail.Text = dgvKhoa.Rows[index].Cells[3].Value.ToString();
                    txtSDT.Text = dgvKhoa.Rows[index].Cells[4].Value.ToString();
                    dtpNgayThanhLap.Value = (DateTime)dgvKhoa.Rows[index].Cells[5].Value;
                }

                catch (Exception)
                {
                    MessageBox.Show("không có giá trị", "Thông báo");
                }

            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThi();
            ClearData();
            txtMaKhoa.Enabled = true;
        }
    }
}

