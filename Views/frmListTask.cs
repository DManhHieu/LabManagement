using QuanLyThanhVien.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThanhVien.Models;
namespace QuanLyThanhVien.Views
{
    public partial class frmListTask : Form
    {
        private int _id;
        public frmListTask(int ID)
        {
            InitializeComponent();
            _id = ID;
            lblNameEmployee.Text = EmployeeController.GetEmployee(ID).FirstName + " " + EmployeeController.GetEmployee(ID).LastName;
            lblPosition.Text = EmployeeController.GetEmployee(ID).Position;
            TaskController.frmListTask = this;
            TaskController.LoadListTask(ID);
        }
        public void AddExpiredTask(Task task)
        {
            urcTask urcTask = new urcTask(task);
            flpExpired.Controls.Add(urcTask);
        }
        public void AddDoingTask(Task task)
        {
            urcTask urcTask = new urcTask(task);
            flpDoing.Controls.Add(urcTask);
        }
        public void AddCompletegTask(Task task)
        {
            urcTask urcTask = new urcTask(task);
            flpComplete.Controls.Add(urcTask);
        }
        private void frmTask_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.flpExpired.Visible = !this.flpExpired.Visible;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            this.flpDoing.Visible = !this.flpDoing.Visible;
        }



        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label50_Click(object sender, EventArgs e)
        {
            this.flpComplete.Visible = !this.flpComplete.Visible;
        }

        private void txtNameNewTask_Enter(object sender, EventArgs e)
        {
            cbNewTask.Visible = true;
            label52.Visible = true;
            label53.Visible = true;
            dtpEndDateNewTask.Visible = true;
            dtpStartDateNewTask.Visible = true;
        }

        private void txtNameNewTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Task task = new Task();
                task.TaskName = txtNameNewTask.Text;
                task.StartDate = dtpStartDateNewTask.Value;
                task.EndDate = dtpEndDateNewTask.Value;
                task.Employees.Add(EmployeeController.GetEmployee(_id));
                task.IDTask = -1;
                task.IDProject = 0;
                
                TaskController.AddOrUpdateTask(task);
            }
        }
    }
}
