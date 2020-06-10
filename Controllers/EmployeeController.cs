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
        public static void LoadList()
        {
            using (var _context=new DBLabManagementEntities())
            {
                foreach(var employee in _context.Employees)
                {
                    if(employee.IDLAB==frmMain._employee.IDLAB)
                        frmEmployees.AddEmployee(employee);
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
                if (employee.IDEmployee == -1)
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
                    urcEmployee.Employee = employee;
                }
                _context.Employees.AddOrUpdate(employee);
                _context.SaveChanges();
                if (isAdd)
                {
                    frmEmployees.AddEmployee(employee);
                }
            }
        }
        public static void Delete(int id)
        {
            using(var _context=new DBLabManagementEntities())
            {
                var EmployeeDelete = _context.Employees.FirstOrDefault(x => x.IDEmployee == id);
                if (EmployeeDelete != null)
                {
                    _context.Employees.Remove(EmployeeDelete);
                    _context.SaveChanges();
                    urcEmployee.Dispose();
                }

            }
        }
    }
}
