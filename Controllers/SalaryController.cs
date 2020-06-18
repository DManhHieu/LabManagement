using Microsoft.Vbe.Interop;
using QuanLyThanhVien.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.Controllers
{
    public class SalaryController
    {
        //public static bool GetID(int IDEmployee)
        //{
        //    using(var _context=new DBLabManagementEntities())
        //    {

        //            var query = (from u in _context.Employees
        //                         where u.IDEmployee == IDEmployee
        //                         select u).Any();
        //            return query;
        //    }
        //}

        public static List<Employee> GetIDEmployee (int IDEmployee)
        {
            using (var _context = new DBLabManagementEntities())
            {
                var Employee = (from u in _context.Employees
                                where u.IDEmployee == IDEmployee
                                select u).ToList();
                if (Employee.Count > 0)
                    return Employee;
                else
                    return null;
            }
        }

        public static List<Salary> getListSalary()
        {
            using(var _context=new DBLabManagementEntities())
            {
                var salary = (from u in _context.Salaries.AsEnumerable()
                              select u)
                            .Select(x => new Salary
                            {
                                IDEmployee = x.IDEmployee,
                                UserName = _context.Employees.FirstOrDefault(e=>e.IDEmployee==x.IDEmployee).ToString(),
                                LuongCoBan = x.LuongCoBan,
                                LuongDaNhan = x.LuongDaNhan,
                                Phat = x.Phat,
                                Month = x.Month,
                                Thuong = x.Thuong,
                                Employee = x.Employee
                            }).ToList();
                return salary;
            }
        }

        public static bool UpdateSalary(Salary salary)
        {
            try
            {
                using (var _context = new DBLabManagementEntities())
                {
                    _context.Salaries.AddOrUpdate(salary);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<Salary> getSalary(DateTime Month)
        {
            using (var _context = new DBLabManagementEntities())
            {
                var salary = (from u in _context.Salaries.AsEnumerable()
                              where u.Month.Month == Month.Month && u.Month.Year==Month.Year
                              select u)
                            .Select(x => new Salary
                            {
                                IDEmployee = x.IDEmployee,
                                UserName = _context.Employees.FirstOrDefault(e => e.IDEmployee == x.IDEmployee).ToString(),
                                LuongCoBan = x.LuongCoBan,
                                LuongDaNhan = x.LuongDaNhan,
                                Phat = x.Phat,
                                Month = x.Month,
                                Thuong = x.Thuong,
                                Employee = x.Employee
                            }).ToList();
                return salary;
            }
        }
        public static bool DeleteSalary(Salary salary)
        {
            using(var _context=new DBLabManagementEntities())
            {
                var dbSalary = (from u in _context.Salaries
                                where u.IDEmployee == salary.IDEmployee && u.Month == salary.Month
                                select u).SingleOrDefault();
                _context.Salaries.Remove(dbSalary);
                _context.SaveChanges();
                return true;
            }
        }

        public static Salary getSalary(int IDEmployee,DateTime Month)
        {
            using(var _context=new DBLabManagementEntities())
            {
                var salary = (from u in _context.Salaries
                              where u.IDEmployee == IDEmployee && u.Month == Month
                              select u).ToList();
                if (salary.Count>0)
                    return salary[0];
                else
                    return null;
            }
        }
    }
}
