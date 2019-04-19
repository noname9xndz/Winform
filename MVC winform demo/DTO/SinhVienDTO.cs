using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVienDTO
    {
        public string MaSinhVien { get; set; }
        public string TenSV { get; set; }
        public string CMT { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public int? SDT {  get; set; }
        public string TenNguoiThan { get; set; }
        public int? SDTNguoiThan { get; set; }
        public string Hinh { get; set; }
        public string MaKhoa { get; set; }
    }
}
