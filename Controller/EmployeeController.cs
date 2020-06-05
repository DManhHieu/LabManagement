using QuanLyThanhVien.Models;
using QuanLyThanhVien.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.Controller
{
    public class EmployeeController
    {
        public static List<Employee> employees;
        public static frmEmployees frmEmployees;
        public static void AddNewEmployee(Employee employee)
        {
            employees.Add(employee);
            frmEmployees.AddViewEmployees(employee);
        }
        public static void LoadList()
        {
            foreach(Employee employee in employees)
            {
                frmEmployees.AddViewEmployees(employee);
            }
        }
    }
}
