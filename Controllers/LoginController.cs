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
        public static bool IsLogin = false;
        public static bool Login(string UserName,string password)
        {
            using (var _context=new DBLabManagementEntities())
            {
                IsLogin = false;
                var employee= _context.Employees.FirstOrDefault(x => x.UserName.Trim() == UserName && x.EPassword.Trim() == password);
                if (employee != null)
                {
                    IsLogin = true;
                    mainController.EmployeeLogin = employee;
                    return true;
                }
            }
            return false;
        }
        public static void AddNewLab(Lab lab, Employee employee)
        {
            using(var _context=new DBLabManagementEntities())
            {
                lab.IDLab = _context.Labs.Count();
                employee.IDEmployee = _context.Employees.Count();
                lab.IDMangager = employee.IDEmployee;
                employee.IDLAB = lab.IDLab;
                employee.Lab = lab;
                lab.Employees.Add(employee);
                _context.Labs.Add(lab);
                _context.Employees.Add(employee);
                _context.SaveChanges();
            }
        }
    }
}
