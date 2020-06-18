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
            btnAddNewEmployee.Visible = mainController.IsManager;
        }
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            EmployeeController.SelectID = -1;
            frmInfoEmployee employee = new frmInfoEmployee();
            employee.Text = "Thêm nhân viên";
 
            mainController.SetView(employee);
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
         

        }
        public void AddEmployee(int IDE)
        {
            urcEmployee employee = new urcEmployee(IDE);
            this.flpEmployees.Controls.Add(employee);
        }
       
    }
}
