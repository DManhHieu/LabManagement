using QuanLyThanhVien.Controllers;
using QuanLyThanhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThanhVien.Views
{
    public partial class frmInfoTask : Form
    {
        private frmListTask _frmListTask=null;
        private frmInfoProject _frmInfoProject=null;
        private urcTask _urcTask;
        private int _model;
        public frmInfoTask(Task task,frmListTask frmListTask, urcTask urcTask)
        {
            InitializeComponent();
            _model =0;
            _frmListTask = frmListTask;
            _urcTask = urcTask;
            Task = task;
        }
        public frmInfoTask(Task task, frmInfoProject frmInfoProject, urcTask urcTask)
        {
            InitializeComponent();
            _model = 1;
            _frmInfoProject = frmInfoProject;
            _urcTask = urcTask;
            Task = task;
        }
        private int ID { get; set; }
        private int IDProject { get; set; }
        private Task Task
        {
            get
            {
                Task task = new Task();
                task.TaskName = txtTaskName.Text;
                task.Status = cbComplete.Checked.ToString();
                task.StartDate = dtpStartDate.Value;
                task.EndDate = dtpEndDate.Value;
                task.IDTask = ID;
                task.IDProject = IDProject;
                task.Description = rtDescription.Text;
                task.Employees = Employees;
                return task;
            }
            set
            {
                ID = value.IDTask;
                IDProject =(int) value.IDProject;
                txtTaskName.Text = value.TaskName;
                cbComplete.Checked = value.Status == true.ToString() ? true : false;
                dtpStartDate.Value = value.StartDate.Value;
                dtpEndDate.Value = value.EndDate.Value;
                rtDescription.Text = value.Description;
                lbEmployees.Items.Clear();
                Employees = TaskController.GetListEmployee(value);
            }
        }
        private List<Employee> _employees;
        private List<Employee> Employees
        {
            get
            {
                return _employees;
            }
            set
            {
                _employees = value;
                foreach (Employee employee in _employees)
                {
                    lbEmployees.Items.Add(employee);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            //this.lbSearchEmployees.Visible = true;
            //this.lbSearchEmployees.Items.Clear();
            //foreach (Employee em in EmployeeController.ListEmployee())
            //{
            //    this.lbSearchEmployees.Items.Add(em);
            //}
            //this.txtSearch.Clear();
            //this.lbSearchEmployees.GotFocus += LbSearchEmployees_GotFocus;
            if (txtSearch.Text == "Tìm kiếm")
            {
                txtSearch.Clear();
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(lbSearchEmployees.Focused==false)
                this.lbSearchEmployees.Visible = false;
        }

        private void lbSearchEmployees_Enter(object sender, EventArgs e)
        {
            lbSearchEmployees.Visible = true;
        }

        private void lbSearchEmployees_Leave(object sender, EventArgs e)
        {
            lbSearchEmployees.Visible = false;
        }

        private void lbSearchEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            var em = EmployeeController.ListEmployee(txtSearch.Text)[lbSearchEmployees.SelectedIndex];
            if( Employees.FirstOrDefault(x => x.IDEmployee == em.IDEmployee)!=null)
                return;
            this.lbEmployees.Items.Add(em);
            Employees.Add(em);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.lbSearchEmployees.Visible = true;
            this.lbSearchEmployees.Items.Clear();
            foreach (Employee em in EmployeeController.ListEmployee(txtSearch.Text))
            {
                    this.lbSearchEmployees.Items.Add(em);
            }
        }

        private void lbEmployees_DoubleClick(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex == -1)
                return;
            Employees.RemoveAt(lbEmployees.SelectedIndex);
            lbEmployees.Items.RemoveAt(lbEmployees.SelectedIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TaskController.Delete(Task,_urcTask);
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_model == 0)
            {
                TaskController.AddOrUpdateTask(Task, _frmListTask, _urcTask);
            }
            else
            {
                TaskController.AddOrUpdateTask(Task, _frmInfoProject, _urcTask);
            }

            this.Close();
        }
    }
}
