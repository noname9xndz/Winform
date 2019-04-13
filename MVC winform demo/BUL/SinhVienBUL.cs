using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class SinhVienBUL
    {
       
        public static List<SinhVienDTO> LoadSinhVien()
        {
            return SinhVienDAL.LoadSinhVien();
        }
       
        public static  bool ThemSinhVien(SinhVienDTO sinhVien)
        {
            bool ketQua = SinhVienDAL.ThemSinhVien(sinhVien);
            return ketQua;

        }
        public static bool CheckSinhVien(string MaSinhVien)
        {
            bool ketQua = SinhVienDAL.CheckSinhVien(MaSinhVien);
            return ketQua;

        }
        public static bool SuaSinhVien(SinhVienDTO sinhVien)
        {
            bool ketqua = SinhVienDAL.SuaSinhVien(sinhVien);
            return ketqua;
        }
        public static bool XoaSinhVien(string maSV)
        {
            bool ketQua = SinhVienDAL.XoaSinhVien(maSV);
            return ketQua;
        }
        
        public static List<SinhVienDTO> TimSinhVien(string tuKhoa)
        {
            return SinhVienDAL.TimSinhVien(tuKhoa);
        }



    }

}
