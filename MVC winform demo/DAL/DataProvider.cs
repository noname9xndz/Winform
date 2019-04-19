using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        public static SqlConnection KetNoi()
        {
            string sqlConnection = @"Data Source = NONAME\NONAME;Initial Catalog = DemoQLKyTuc;Integrated Security = False;User Id = sa; Password=noname9xnd;MultipleActiveResultSets=True";
            SqlConnection conn = new SqlConnection(sqlConnection);
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }
        // c1
        public static DataTable TruyVanDataTable(string truyvan)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(truyvan, KetNoi());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                KetNoi().Close();
                return dataTable;
            }
            catch(Exception)
            {
                KetNoi().Close();
                return null;
            }
            
        }
        //c2
        public static DataTable TruyVanDataReader(string truyvan)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(truyvan, KetNoi());
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                KetNoi().Close();
                return dataTable;

            }
            catch (Exception)
            {
                KetNoi().Close();
                return null;
            }

        }

        #region thực thi CURUD

        public static bool TruyVanExecuteNonQuery(string truyvan)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(truyvan, KetNoi());
                int check = sqlCommand.ExecuteNonQuery();
                KetNoi().Close();
                if (check > 0)
                {
                    return true; // thành công
                }
                else
                {
                    return false; // thất bại
                }

            }
            catch (Exception)
            {
                KetNoi().Close();
                return false;
            }
        }
        // trụy vấn trả vê 1  kết quả
        public static string TruyVanExecuteScalar(string truyvan)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(truyvan, KetNoi());
                string ketqua = sqlCommand.ExecuteScalar().ToString();
                KetNoi().Close();
                return ketqua;
               

            }
            catch (Exception)
            {
                KetNoi().Close();
                return null;
            }
        }



        #endregion
    }
}
