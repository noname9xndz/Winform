using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class KhoaBUL
    {
        public static List<KhoaDTO> LoadKhoa()
        {
            return KhoaDAL.Loadkhoa();
        }
    }
}
