using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b1_test
{
    static class Program
    {
        /*
    * tham khảo : http://www.iceteaviet.com/2015/07/bai-01-thuoc-tinh-phuong-thuc-su-kien.html

        */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
            //Application.Run(new Form2());
            Application.Run(new Form3());
        }
    }
}
