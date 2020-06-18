using QuanLyThanhVien.Controllers;
using QuanLyThanhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.Views
{
    public partial class frmSetTime : Form
    {
        public frmSetTime(Employee employee, DateTime day)
        {
            InitializeComponent();
            Employee = employee;
            Day = day;
            
           
        }
        private Employee _employee;
        public Employee Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                _employee = value;
                lblNameEmployee.Text = value.ToString();
            }
        }

        public DateTime Day
        {
            get
            {
                return dtpDay.Value;
            }
            set
            {
                dtpDay.Value = value;

            }
        }
        public void AddTime(TimeWork timeWork)
        {
            urcWorkTime urcWorkTime = new urcWorkTime(timeWork);
            flpListTimeWork.Controls.Add(urcWorkTime);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDay_ValueChanged(object sender, EventArgs e)
        {
            flpListTimeWork.Controls.Clear();
            TimeWorkController.LoadListTime(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeWork timeWork = new TimeWork();
            //timeWork.Employee = Employee;
            timeWork.StartDate = Day.Date + dtpStartTimeNew.Value.TimeOfDay;
            timeWork.EndDate = Day.Date + dtpEndTimeNew.Value.TimeOfDay;
            //timeWork.IDEmployee = Employee.IDEmployee;
            TimeWorkController.AddWorkTime(Employee, timeWork,this);
        }
    }
}
