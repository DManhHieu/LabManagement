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
        private Task Task;
        public frmInfoTask(Task task)
        {
            InitializeComponent();
            Task = task;
            txtTaskName.Text = task.TaskName;
            cbComplete.Checked = task.Status==true.ToString() ? true : false;
            dtpStartDate.Value = task.StartDate.Value;
            dtpEndDate.Value= task.EndDate.Value;
            rtDescription.Text = task.Description;
            lbEmployees.Items.Clear();
            foreach(Employee employee in TaskController.GetListEmployee(task))
            {
                lbEmployees.Items.Add(employee);
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
