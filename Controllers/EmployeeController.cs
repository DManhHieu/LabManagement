using QuanLyThanhVien.Models;
using QuanLyThanhVien.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.Controllers
{
    public class EmployeeController
    {
        public static frmEmployees frmEmployees;
        public static urcEmployee urcEmployee;
        public static int SelectID;
        public static void LoadList()
        {
            using (var _context=new DBLabManagementEntities())
            {
                foreach(var employee in _context.Employees)
                {
                    if(employee.IDLAB==mainController.Lab.IDLab)
                        frmEmployees.AddEmployee(employee.IDEmployee);
                }
            }
        }
        public static List<Employee> ListEmployee()
        {
            using (var _context = new DBLabManagementEntities())
            {
               return _context.Employees.Where(x => x.IDLAB == mainController.Lab.IDLab).ToList();
               
            }
        }
        public static Employee SelectEmployee
        {
            get
            {
                if (SelectID == -1)
                {
                    return null;
                }
                using (var _context = new DBLabManagementEntities())
                {
                    return _context.Employees.FirstOrDefault(x=>x.IDEmployee==SelectID);
                }
            }
        }
        public static Employee GetEmployee(int ID)
        {
            using (var _context=new DBLabManagementEntities())
            {
                return _context.Employees.FirstOrDefault(x => x.IDEmployee == ID);
            }
        }
        public static void AddorUpdate(Employee employee)
        {
            using (var _context=new DBLabManagementEntities())
            {
                bool isAdd=false;
                if (SelectID==-1)
                {
                    isAdd = true;
                    var Ids = (from e in _context.Employees select e.IDEmployee).ToList();
                    for(int i = 1; i <= _context.Employees.Count() + 1; i++)
                    {
                        if (!Ids.Contains(i))
                        {
                            employee.IDEmployee = i;
                            break;
                        }
                    }
                  
                }
                else
                {
                    if(urcEmployee!=null)
                    urcEmployee.Employee = employee;
                }
                _context.Employees.AddOrUpdate(employee);
                _context.SaveChanges();
                if (isAdd)
                {
                    frmEmployees.AddEmployee(employee.IDEmployee);
                }
            }
        }
        public static void Delete()
        {
            using(var _context=new DBLabManagementEntities())
            {
                var EmployeeDelete = _context.Employees.FirstOrDefault(x => x.IDEmployee == SelectID);
                if (EmployeeDelete != null)
                {
                    _context.Employees.Remove(EmployeeDelete);
                    _context.SaveChanges();
                    urcEmployee.Dispose();
                }

            }
        }
        public static bool IsManager
        {
            get
            {
                using (var _context = new DBLabManagementEntities())
                {
                    var ep = _context.Employees.FirstOrDefault(x => x.IDEmployee == SelectID);

                    return ep.IDEmployee == ep.Lab.IDMangager;
                }
            }
        }
        public static List<Employee> ListEmployee(string t)
        {
            using(var _context=new DBLabManagementEntities())
            {
                return _context.Employees.Where(x => x.IDLAB == mainController.Lab.IDLab && (x.FirstName + " " + x.LastName).Contains(t)).ToList();
            }
        }
    }
}
