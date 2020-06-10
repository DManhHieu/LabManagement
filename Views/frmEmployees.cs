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
    public partial class frmEmployees : Form
    {
       
        public frmEmployees()    
        {
            InitializeComponent();
            EmployeeController.frmEmployees = this;
            EmployeeController.LoadList();
           
        }
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmInfoEmployee employee = new frmInfoEmployee(-1);
            employee.Text = "Thêm nhân viên";
            mainController.SetView(employee);
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
         

        }
        public void AddEmployee(Employee _employee)
        {
            urcEmployee employee = new urcEmployee(_employee.IDEmployee);
            this.flpEmployees.Controls.Add(employee);
        }
       
    }
}
