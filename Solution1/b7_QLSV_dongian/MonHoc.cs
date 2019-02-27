using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b7_QLSV_dongian
{
    public class MonHoc
    {
        public string MaMH { set; get; }
        public string TenMH { set; get; }
        public decimal HocPhi { set; get; }

        public MonHoc()
        {

        }
        public MonHoc(string MaMH,string TenMH,decimal HocPhi)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
            this.HocPhi = HocPhi;
        }

        public static List<MonHoc> KhoiTaoDuLieu()
        {
            List<MonHoc> listMH = new List<MonHoc>();
            listMH.Add(new MonHoc()
            {
                MaMH = "MH01",
                TenMH = "Toán Cao Cấp",
                HocPhi = 32423434
            });

            listMH.Add(new MonHoc(){ MaMH = " MH02",TenMH = "Tin Cơ Sở", HocPhi = 4342 });
            listMH.Add(new MonHoc() { MaMH = "MH03", TenMH = "Công Nghệ PM", HocPhi =656456 });
            listMH.Add(new MonHoc() { MaMH = "MH04", TenMH = "Cơ sở dữ liệu", HocPhi = 979898 });
            listMH.Add(new MonHoc() { MaMH = "MH05", TenMH = "JAVA cơ bản", HocPhi = 1212123 });
            listMH.Add(new MonHoc() { MaMH = "MH06", TenMH = "C# cơ bản", HocPhi = 7876786 });

            return listMH;
        }
    }

}
