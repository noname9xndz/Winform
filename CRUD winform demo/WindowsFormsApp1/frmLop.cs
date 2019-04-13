using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private SqlConnection connection = new SqlConnection(@"Data Source = NONAME\NONAME;Initial Catalog = svtest;Integrated Security = False;User Id = sa; Password=noname9xnd;MultipleActiveResultSets=True");
        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlDataReader;
        private DataSet dataSet;
        

        

        private void frmLop_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        public void HienThi()
        {
            connection.Open();
            string query = "select * from tblLop";
            string query2 = "select * from tblKhoa";

            //c1 dùng sqlCommand + sqldatareader
            sqlCommand = new SqlCommand(query2, connection);
            sqlDataReader = sqlCommand.ExecuteReader();

            dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            // đổ dữ liệu lên combox
            cboMaKhoa.DataSource = dataTable;
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "MaKhoa";

            //c2 dùng sqlDataAdapter
            sqlDataAdapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "tblSinhVien");
            dgvLop.DataSource = dataSet.Tables["tblSinhVien"];

            //sqlCommand = new SqlCommand(query, connection);
            //sqlDataReader = sqlCommand.ExecuteReader();

            //dataTable = new DataTable();
            //dataTable.Load(sqlDataReader);


            connection.Close();
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
