using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThanhVien.Models;
using QuanLyThanhVien.Controllers;

namespace QuanLyThanhVien.Views
{
    public partial class urcTime : UserControl
    {
        public urcTime(Employee employee,DateTime monday)
        {
            InitializeComponent();
            _monday = monday;
            Employee = employee;
            lblWorkTimeOfWeek.Text = TimeWorkController.WeekTime(employee, monday).TotalHours.ToString("0.00");
        }

        private void Settime_Click(object sender, EventArgs e)
        {
            var lst = sender as ListBox;
            int day= int.Parse(lst.Tag.ToString());
            frmSetTime setTime = new frmSetTime(Employee,_monday.AddDays(day));
            setTime.ShowDialog();
            lst.Items.Clear();
            lst.Items.AddRange(TimeWorkController.Work(Employee, _monday.AddDays(day)).ToArray());
            lblWorkTimeOfWeek.Text = TimeWorkController.WeekTime(employee, _monday).TotalHours.ToString("0.00");
        }
        private DateTime _monday;
        private Employee employee;
        private Employee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
                lblEmployee.Text = value.ToString();
                lsbMonday.Items.Clear();
                lsbMonday.Items.AddRange(TimeWorkController.Work(value, _monday).ToArray());
                lsbTuesday.Items.Clear();
                lsbTuesday.Items.AddRange(TimeWorkController.Work(value, _monday.AddDays(1)).ToArray());
                lsbWednesday.Items.Clear();
                lsbWednesday.Items.AddRange(TimeWorkController.Work(value, _monday.AddDays(2)).ToArray());
                lsbThursday.Items.Clear();
                lsbThursday.Items.AddRange(TimeWorkController.Work(value, _monday.AddDays(3)).ToArray());
                lsbFriday.Items.Clear();
                lsbFriday.Items.AddRange(TimeWorkController.Work(value, _monday.AddDays(4)).ToArray());
                lsbSaturday.Items.Clear();
                lsbSaturday.Items.AddRange(TimeWorkController.Work(value, _monday.AddDays(5)).ToArray());
                lsbSunday.Items.Clear();
                lsbSunday.Items.AddRange(TimeWorkController.Work(value, _monday.AddDays(6)).ToArray());
            }
        }

    }
}
