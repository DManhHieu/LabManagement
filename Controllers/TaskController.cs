using QuanLyThanhVien.Models;
using QuanLyThanhVien.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace QuanLyThanhVien.Controllers
{
    public class TaskController
    {
        public static frmListTask frmListTask;
        
        public static void LoadListTask(int IDEmployee)
        {
            using(var _context=new DBLabManagementEntities())
            {
                var employee = _context.Employees.FirstOrDefault(x => x.IDEmployee == IDEmployee);
                if (employee == null)
                {
                    return;
                }
                
                foreach (Task task in employee.Tasks)
                {
                    AddTask(task);
                }
            }
        }
        private static void AddTask(Task task )
        {
            if (task.Status == true.ToString())
                frmListTask.AddCompletegTask(task);
            else
            {
                if (task.EndDate.Value > DateTime.Now)
                {
                    frmListTask.AddDoingTask(task);
                }
                else
                {
                    frmListTask.AddExpiredTask(task);
                }
            }

        }
        public static void AddOrUpdateTask(Task task)
        {
            using (var _context=new DBLabManagementEntities())
            {
                if (task.IDTask == -1)
                {
                    var Ids = (from t in _context.Tasks select t.IDTask).ToList();
                    for (int i = 1; i <= _context.Tasks.Count() + 1; i++)
                    {
                        if (!Ids.Contains(i))
                        {
                            task.IDTask = i;
                            break;
                        }
                    }
                }
                _context.Tasks.AddOrUpdate(task);
                _context.SaveChanges();
                AddTask(task);
            }
        }
        public static List<Employee> GetListEmployee(Task task)
        {
            using(var _context=new DBLabManagementEntities())
            {
                var _task=_context.Tasks.FirstOrDefault(x => x.IDTask == task.IDTask);
                return _task.Employees.ToList();
            }
        }
    }
}
