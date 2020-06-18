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
        public static void LoadListTask(Employee e, frmListTask frmListTask)
        {
            using(var _context=new DBLabManagementEntities())
            {
                var employee = _context.Employees.FirstOrDefault(x => x.IDEmployee == e.IDEmployee );
                if (employee == null)
                {
                    return;
                }
                foreach (Task task in employee.Tasks)
                {
                    AddTask(task,frmListTask);
                }
            }
        }
        public static List<Project> GetListProject()
        {
            using (var _context = new DBLabManagementEntities())
            {
                var ListProject = _context.Projects.Where(x => x.IDLab == mainController.Lab.IDLab);
                return ListProject.ToList();
            }
        }
        public static Project GetProject(Task task)
        {
            using(var _context=new DBLabManagementEntities())
            {
                var project = _context.Projects.FirstOrDefault(x => x.IDProject == task.IDProject);
                return project;
            }
        }
        public static void AddOrUpdateTask(Task task)
        {
            using (var _context=new DBLabManagementEntities())
            {
                _context.Tasks.AddOrUpdate(task);
                _context.SaveChanges();
            }
        }
        private static void AddTask(Task task,frmListTask frmListTask)
        {
            if (frmListTask == null)
            {
                return;
            }
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
        public static void AddNewTask(Task task, Employee em,frmListTask frmListTask)
        {
            using(var _context=new DBLabManagementEntities())
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
     
                var employee = _context.Employees.FirstOrDefault(x => x.IDEmployee == em.IDEmployee);
                if (employee == null)
                    return;
                employee.Tasks.Add(task);
                _context.Employees.AddOrUpdate(employee);
                _context.Tasks.Add(task);
                _context.SaveChanges();
                AddTask(task,frmListTask);

            }
        }
        public static void AddNewTask(Task task, frmInfoProject frmInfoProject)
        {
            using (var _context = new DBLabManagementEntities())
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
                _context.Tasks.Add(task);
                _context.SaveChanges();
                frmInfoProject.AddTask(task);
            }
        }
            public static void AddOrUpdateTask(Task task,frmListTask frmListTask,urcTask urcTask)
        {
            using (var _context=new DBLabManagementEntities())
            {
                var t = _context.Tasks.FirstOrDefault(x => x.IDTask == task.IDTask);
                t.Employees.Clear();
                _context.Tasks.AddOrUpdate(t);
                foreach (var em in task.Employees)
                {
                    var employee = _context.Employees.FirstOrDefault(x => x.IDEmployee == em.IDEmployee);
                    employee.Tasks.Add(t);
                }
                _context.Tasks.AddOrUpdate(task);
                _context.SaveChanges();
                urcTask.Dispose();
                AddTask(task,frmListTask);
            }
        }
        public static void AddOrUpdateTask(Task task, frmInfoProject frmInfoProject, urcTask urcTask)
        {
            using (var _context = new DBLabManagementEntities())
            {
                var t = _context.Tasks.FirstOrDefault(x => x.IDTask == task.IDTask);
                t.Employees.Clear();
                _context.Tasks.AddOrUpdate(t);
                foreach (var em in task.Employees)
                {
                    var employee = _context.Employees.FirstOrDefault(x => x.IDEmployee == em.IDEmployee);
                    employee.Tasks.Add(t);
                }
                _context.Tasks.AddOrUpdate(task);
                _context.SaveChanges();
                urcTask.Dispose();
                frmInfoProject.AddTask(task);
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
        public static void Delete(Task t,urcTask urcTask)
        {
            using(var _context=new DBLabManagementEntities())
            {
                var task = _context.Tasks.FirstOrDefault(x => x.IDTask == t.IDTask);
                foreach(var employee in task.Employees)
                {
                    var e = _context.Employees.FirstOrDefault(x => x.IDEmployee == employee.IDEmployee);
                    if (e != null)
                        e.Tasks.Remove(task);
                }
                _context.Tasks.Remove(task);
                _context.SaveChanges();
                urcTask.Dispose();
            }
        }
        public static void Delete(Task t)
        {
            using (var _context = new DBLabManagementEntities())
            {
                var task = _context.Tasks.FirstOrDefault(x => x.IDTask == t.IDTask);
                foreach (var employee in task.Employees)
                {
                    var e = _context.Employees.FirstOrDefault(x => x.IDEmployee == employee.IDEmployee);
                    if (e != null)
                        e.Tasks.Remove(task);
                }
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
        }
    }
}
