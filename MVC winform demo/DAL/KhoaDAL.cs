using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoaDAL
    {
        // load Khoa
        public static List<KhoaDTO> Loadkhoa()
        {
            string truyvan = @"SELECT * FROM tbl_Khoa";

            DataTable dataTable = DataProvider.TruyVanDataReader(truyvan);

            KhoaDTO khoa;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                List<KhoaDTO> listkhoa = new List<KhoaDTO>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    khoa = new KhoaDTO
                    {
                        MaKhoa = dataTable.Rows[i]["Makhoa"].ToString(),  //1
                        TenKhoa = dataTable.Rows[i]["TenKhoa"].ToString(),   //2
                    };

                    listkhoa.Add(khoa);
                }
                return listkhoa;
            }
            return null;


        }
    }
}
