using QuanLyThanhVien.Controller;
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
    public partial class frmEmployees : Form
    {
        private List<Employee> Employees;
        public frmEmployees()    
        {
            InitializeComponent();
            EmployeeController.frmEmployees = this;
           
           
        }
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmInfoEmployee employee = new frmInfoEmployee(null);
            employee.Text = "Thêm thành viên";
            testcontroller.SetViewForm1(employee);
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            EmployeeController.LoadList();

        }
        public void AddViewEmployees(Employee employee)
        {
            this.flpEmployees.Controls.Add(new urcEmployee(employee));
        }
    }
}
