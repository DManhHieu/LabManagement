using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThanhVien.Controller;
using QuanLyThanhVien.Models;

namespace QuanLyThanhVien.Views
{
    public partial class urcEmployee : UserControl
    {
        public urcEmployee(Employee employee)
        {
            InitializeComponent();
            this.Employee = employee;
            FullName = employee.FirstName + " " + employee.LastName;
            
        }
        private Employee Employee;
        private void button1_Click(object sender, EventArgs e)
        {
            frmInfoEmployee thongtin = new frmInfoEmployee(this.Employee);
            testcontroller.SetViewForm1(thongtin);
        }
        public string FullName
        {
            set
            {
                this.lblName.Text = value;
            }
        }
        public string Position
        {
            set
            {
                this.lblPosition.Text = value;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmListTask task = new frmListTask();
            testcontroller.SetViewForm1(task);
        }
    }
}
