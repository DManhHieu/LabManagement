using QuanLyThanhVien.Models;
using QuanLyThanhVien.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.Controllers
{
    public class mainController
    {
        public static frmMain _main;
        public static Employee EmployeeLogin;
        public static Lab Lab
        {
            get
            {
                using(var _context=new DBLabManagementEntities())
                {
                    return _context.Labs.FirstOrDefault(x => x.IDLab == EmployeeLogin.IDLAB);
                    
                }
            }
        }
        public static bool IsManager
        {
            get
            {
                using(var _context=new DBLabManagementEntities())
                {
                    return Lab.IDMangager == EmployeeLogin.IDEmployee;
                    //return EmployeeLogin.IDEmployee == EmployeeLogin.Lab.IDMangager;
                }
            }
        }
        public static void SetView(Form form)
        {
            _main.SetView(form);
        }
    }
}
