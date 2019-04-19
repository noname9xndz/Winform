using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUL
{
    public class SinhVienDAL
    {
        // load sinh viên
        public static List<SinhVienDTO> LoadSinhVien()
        {
            string truyvan = "SELECT * FROM tbl_SinhVien";

            DataTable dataTable = DataProvider.TruyVanDataReader(truyvan);
            // DataTable dataTable = DataProvider.TruyVanDataTable(truyvan);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                SinhVienDTO sinhVien;
                List<SinhVienDTO> listSinhVien = new List<SinhVienDTO>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    sinhVien = new SinhVienDTO();
                    // sinhVien.MaSinhVien =Convert.ToInt32( dataTable.Rows[i]["MaSinhVien"]);
                    // sinhVien.GioiTinh =Convert.ToBoolean(dataTable.Rows[i]["GioiTinh"]);
                    sinhVien.MaSinhVien = dataTable.Rows[i]["MaSinhVien"].ToString();  //1
                    sinhVien.TenSV = dataTable.Rows[i]["TenSV"].ToString();   //2
                    sinhVien.CMT = dataTable.Rows[i]["CMT"].ToString();//3
                    sinhVien.NgaySinh = Convert.ToDateTime(dataTable.Rows[i]["NgaySinh"]);//4
                    sinhVien.GioiTinh = dataTable.Rows[i]["GioiTinh"].ToString();//5
                    sinhVien.QueQuan = dataTable.Rows[i]["QueQuan"].ToString();//6
                    if (dataTable.Rows[i]["SDT"] == DBNull.Value)
                    {
                        sinhVien.SDT = 0;
                       
                    }
                    else
                    {
                        sinhVien.SDT = Convert.ToInt32(dataTable.Rows[i]["SDT"]);//7

                    }
                    sinhVien.TenNguoiThan = dataTable.Rows[i]["TenNguoiThan"].ToString();//8
                    if (dataTable.Rows[i]["SDTNguoiThan"]== DBNull.Value)
                    {
                        sinhVien.SDTNguoiThan = 0;
                    }
                    else
                    {
                        sinhVien.SDTNguoiThan = Convert.ToInt32(dataTable.Rows[i]["SDTNguoiThan"]);//9
                    }
                    
                    sinhVien.Hinh = dataTable.Rows[i]["Hinh"].ToString();//10
                    sinhVien.MaKhoa = dataTable.Rows[i]["MaKhoa"].ToString();//11

                    listSinhVien.Add(sinhVien);
                }
                return listSinhVien;
            }
            return null;


        }

        // thêm nhân viên
        public static bool ThemSinhVien(SinhVienDTO sinhVien)
        {
            string truyvan = string.Format(@"INSERT INTO tbl_SinhVien(MaSinhVien,TenSV,CMT,NgaySinh,GioiTinh,QueQuan,SDT,TenNguoiThan,SDTNguoiThan,MaKhoa,Hinh)" +
                " VALUES ('{0}',N'{1}','{2}','{3}',N'{4}',N'{5}',{6},N'{7}',{8},'{9}',N'{10}')", sinhVien.MaSinhVien, sinhVien.TenSV, sinhVien.CMT, sinhVien.NgaySinh, sinhVien.GioiTinh,
                sinhVien.QueQuan, sinhVien.SDT, sinhVien.TenNguoiThan, sinhVien.SDTNguoiThan, sinhVien.MaKhoa, sinhVien.Hinh);
            bool ketQua = DataProvider.TruyVanExecuteNonQuery(truyvan);
            return ketQua;


        }
        public static bool CheckSinhVien(string MaSinhVien)
        {
            string truyvan = string.Format(@"Select * from tbl_SinhVien Where MaSinhVien = N'{0}'", MaSinhVien);
            bool ketQua = DataProvider.TruyVanExecuteNonQuery(truyvan);
            return ketQua;


        }
        public static bool SuaSinhVien(SinhVienDTO sinhVien)
        {
            string TruyVan = string.Format(@"UPDATE tbl_SinhVien SET TenSV=N'{0}',CMT='{1}',NgaySinh='{2}',GioiTinh=N'{3}',QueQuan=N'{4}',SDT={5},TenNguoiThan=N'{6}',SDTNguoiThan={7},MaKhoa='{8}',Hinh='{9}' where MaSinhVien ='{10}'",
                sinhVien.TenSV, sinhVien.CMT, sinhVien.NgaySinh, sinhVien.GioiTinh, sinhVien.QueQuan, sinhVien.SDT, sinhVien.TenNguoiThan, sinhVien.SDTNguoiThan, sinhVien.MaKhoa, sinhVien.Hinh, sinhVien.MaSinhVien);
            bool ketQua = DataProvider.TruyVanExecuteNonQuery(TruyVan);
            return ketQua;
        }

        public static bool XoaSinhVien(string maSV)
        {
            string sChuoiTruyVan = string.Format(@"DELETE FROM tbl_SinhVien WHERE MaSinhVien=N'{0}' ", maSV);
            bool ketQua = DataProvider.TruyVanExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }

        public static List<SinhVienDTO> TimSinhVien(string tuKhoa)
        {
            string sChuoiTruyVan = string.Format(@"select * From tbl_SinhVien WHERE MaSinhVien Like N'%{0}%' or TenSV Like N'%{0}%' ", tuKhoa);
            DataTable dataTable = DataProvider.TruyVanDataReader(sChuoiTruyVan);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                SinhVienDTO sinhVien;
                List<SinhVienDTO> listSinhVien = new List<SinhVienDTO>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    sinhVien = new SinhVienDTO
                    {
                        MaSinhVien = dataTable.Rows[i]["MaSinhVien"].ToString(),  //1
                        TenSV = dataTable.Rows[i]["TenSV"].ToString(),   //2
                        CMT = dataTable.Rows[i]["CMT"].ToString(),//3
                        NgaySinh = Convert.ToDateTime(dataTable.Rows[i]["NgaySinh"]),//4
                        GioiTinh = dataTable.Rows[i]["GioiTinh"].ToString(),//5
                        QueQuan = dataTable.Rows[i]["QueQuan"].ToString(),//6
                        SDT = Convert.ToInt32(dataTable.Rows[i]["SDT"]),//7
                        TenNguoiThan = dataTable.Rows[i]["TenNguoiThan"].ToString(),//8
                        SDTNguoiThan = Convert.ToInt32(dataTable.Rows[i]["SDTNguoiThan"]),//9
                        Hinh = dataTable.Rows[i]["Hinh"].ToString(),//10
                        MaKhoa = dataTable.Rows[i]["MaKhoa"].ToString()//11
                    };

                    listSinhVien.Add(sinhVien);
                }
                return listSinhVien;
            }
            return null;

        }

    }
}
