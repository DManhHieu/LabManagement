using QuanLyThanhVien.Models;
using QuanLyThanhVien.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.Controllers
{
    public class LoginController
    {
        public static bool Manager = false;
        public static bool IsLogin = false;
        public static int IDLab { get; set; }
        public static bool Login(string UserName,string password)
        {
            using (var _context=new DBLabManagementEntities())
            {
                var employee= _context.Employees.FirstOrDefault(x => x.UserName == UserName && x.EPassword == password);
                if (employee != null)
                {
                    IsLogin = true;
                    frmMain._employee = employee;
                    if(employee.IDLAB!=null)
                    IDLab = (int)employee.IDLAB;
                    else { IDLab = 0; }
                    return true;
                }
            }
            return false;
        }
    }
}
