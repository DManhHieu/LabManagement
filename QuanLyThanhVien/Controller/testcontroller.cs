using QuanLyThanhVien.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.Controller
{
    public static class testcontroller
    {
        public static frmMain Form1;
        //public static frmCacThanhVien CacThanhVien;
        public static void SetViewForm1(Form form)
        {
            Form1.SetView(form);
        }
    }
}
