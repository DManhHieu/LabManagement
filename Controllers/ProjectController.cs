using QuanLyThanhVien.Models;
using QuanLyThanhVien.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThanhVien.Controllers
{
    public class ProjectController
    {
        public static float intComplete(Project project)
        {
            using(var _context=new DBLabManagementEntities())
            {
                int t = _context.Tasks.Where(x => x.IDProject == project.IDProject && x.Status == "True").Count();
                int m = _context.Tasks.Where(x => x.IDProject == project.IDProject).Count();
                if (m == 0) return 0;
                return (float)t / m;
            }
        }
        public static Employee GetManager(Project project)
        {
            using(var _context=new DBLabManagementEntities())
            {
                return _context.Employees.FirstOrDefault(x => x.IDEmployee == project.IDManager);
            }
        }
        public static void LoadList(frmListProjects frmListProjects)
        {
            using (var _context = new DBLabManagementEntities())
            {
                var project = _context.Projects.Where(x => x.IDLab == mainController.Lab.IDLab);
                foreach( Project p in project)
                {
                    AddurcProject(p, frmListProjects);
                }
               
            }
        }
        private static void AddurcProject(Project project, frmListProjects frm)
        {
            if (project.Status.Trim() == "0")
            {
                frm.AddToDo(project);
            }
            else
            if (project.Status.Trim() == "1")
            {
                frm.AddDoing(project);
            }
            else
            {
                frm.AddComplete(project);
            }
        }
        private static List<Task> ListTask(Project project)
        {
            using(var _context=new DBLabManagementEntities())
            {
                return _context.Tasks.Where(x => x.IDProject == project.IDProject).ToList();
            }
        }
        public static void LoadListTask(Project project,frmInfoProject frmInfoProject)
        {
            foreach(var tast in ListTask(project))
            {
                frmInfoProject.AddTask(tast);
            }
        }
        public static void Delete(Project project)
        {
            using (var _context = new DBLabManagementEntities())
            {
                var del = _context.Projects.FirstOrDefault(x => x.IDProject == project.IDProject);
                _context.Projects.Remove(del);
                _context.SaveChanges();
            }
        }
        public static void Update(Project project,frmListProjects frm,urcProject urc)
        {
            using (var _context = new DBLabManagementEntities())
            {
                _context.Projects.AddOrUpdate(project);
                _context.SaveChanges();
                urc.Dispose();
                AddurcProject(project, frm);
            }
        }
        public static void Add(Project project,frmListProjects frm)
        {
            using (var _context = new DBLabManagementEntities())
            {
                var Ids = (from t in _context.Projects select t.IDProject).ToList();
                for (int i = 1; i <= _context.Projects.Count() + 1; i++)
                {
                    if (!Ids.Contains(i))
                    {
                        project.IDProject = i;
                        break;
                    }
                }
                project.IDLab = mainController.Lab.IDLab;
                _context.Projects.Add(project);
                _context.SaveChanges();
          
                AddurcProject(project, frm);
            }
        }
    }
}
