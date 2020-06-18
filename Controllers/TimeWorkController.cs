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
    public class TimeWorkController
    {
        public static List<TimeWork> Work(Employee employee ,DateTime time)
        {
            using(var _context=new DBLabManagementEntities())
            {
                List<TimeWork> list = new List<TimeWork>();
               foreach(var w in _context.TimeWorks.Where(x => x.IDEmployee == employee.IDEmployee))
                {
                    if (w.StartDate.Value.Date == time.Date)
                    {
                        list.Add(w);
                    }
                }
                return list;
            }
        }
        public static TimeSpan WeekTime(Employee employee, DateTime time)
        {
            using(var _context=new DBLabManagementEntities())
            {
                TimeSpan t=new TimeSpan();
                foreach (var w in _context.TimeWorks.Where(x => x.IDEmployee == employee.IDEmployee))
                {
                    if (w.StartDate>time && w.StartDate<time.AddDays(6))
                    {
                        t += w.EndDate.Value - w.StartDate.Value;

                    }
                }
                return t;
            }
        }
        public static void LoadList(frmTime frmTime)
        {
            using(var _context=new DBLabManagementEntities())
            {
                foreach (var employee in _context.Employees)
                {
                    if (employee.IDLAB == mainController.Lab.IDLab)
                        frmTime.AddTime(employee);
                }
            }
        }
        public static void LoadListTime(frmSetTime frmSetTime)
        {
            using(var _context=new DBLabManagementEntities())
            {
                foreach(var time in _context.TimeWorks.Where(x => x.IDEmployee == frmSetTime.Employee.IDEmployee).OrderBy(x=>x.StartDate))
                {
                    if (time.StartDate.Value.Date == frmSetTime.Day.Date)
                    {
                        frmSetTime.AddTime(time);
                    }
                }
            }
        }
        public static void AddWorkTime(Employee employee,TimeWork timeWork,frmSetTime frmSetTime)
        {
            using(var _context=new DBLabManagementEntities())
            {
                var Ids = (from t in _context.TimeWorks select t.IDTimeWork).ToList();
                for (int i = 1; i <= _context.TimeWorks.Count() + 1; i++)
                {
                    if (!Ids.Contains(i))
                    {
                        timeWork.IDTimeWork = i;
                        break;
                    }
                }
                var em = _context.Employees.FirstOrDefault(x => x.IDEmployee == employee.IDEmployee);
                em.TimeWorks.Add(timeWork);
                _context.TimeWorks.Add(timeWork);
                _context.SaveChanges();
                frmSetTime.AddTime(timeWork);
            }
        }
        public static void UpdateWorkTime(TimeWork timeWork)
        {
            using (var _context = new DBLabManagementEntities())
            {
               
                _context.TimeWorks.AddOrUpdate(timeWork);
                _context.SaveChanges();
              
            }
        }
        public static void Delete(TimeWork timeWork)
        {
            using (var _context = new DBLabManagementEntities())
            {
                var dele = _context.TimeWorks.FirstOrDefault(x => x.IDTimeWork == timeWork.IDTimeWork);
                _context.TimeWorks.Remove(dele);
                _context.SaveChanges();

            }
        }
    }
}
