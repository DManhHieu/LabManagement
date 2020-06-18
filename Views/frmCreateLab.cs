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
    public partial class frmCreateLab : Form
    {
        public frmCreateLab()
        {
            InitializeComponent();
        }
        public Lab Lab
        {
            get
            {
                Lab lab = new Lab();
                lab.LabName = this.txtLabName.Text;
                return lab;
            }
        }
        public Employee Employee
        {
            get
            {
                Employee employee = new Employee();
                employee.UserName = txtUserName.Text;   
                employee.EPassword = txtPassword.Text;
                employee.Birthday = dtpBirthday.Value;
                employee.Email = txtEmail.Text;
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;
                return employee;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
                LoginController.AddNewLab(Lab, Employee);
                this.Close();

        }
    }
}
