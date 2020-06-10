using QuanLyThanhVien.Models;
using QuanLyThanhVien.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.Controllers
{
    public class mainController
    {
        public static frmMain _main;
        public static string LabName(Employee employee)
        {
            using(var _context=new DBLabManagementEntities())
            {
                var lab = _context.Labs.FirstOrDefault(x => x.IDLab == employee.IDLAB);
                if (lab == null)
                {
                    return "";
                }

                return lab.LabName;

            }
        }
        public static void SetView(Form form)
        {
            _main.SetView(form);
        }
    }
}
