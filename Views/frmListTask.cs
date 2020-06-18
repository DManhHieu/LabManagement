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
        private Employee Employee { get; set; }
        public frmListTask(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
            lblNameEmployee.Text = employee.ToString();
            lblPosition.Text = employee.Position;
            TaskController.LoadListTask(employee,this);
        }
        public void AddExpiredTask(Task task)
        {
          
            urcTask urcTask = new urcTask(task,this);

            flpExpired.Controls.Add(urcTask);
        }
        public void AddDoingTask(Task task)
        {
            urcTask urcTask = new urcTask(task,this);
            flpDoing.Controls.Add(urcTask);
        }
        public void AddCompletegTask(Task task)
        {
            urcTask urcTask = new urcTask(task,this);
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
            if (txtNameNewTask.Text == "Thêm công việc mới")
            {
                txtNameNewTask.Clear();
                cbNewTask.Visible = true;
                label52.Visible = true;
                label53.Visible = true;
                dtpEndDateNewTask.Visible = true;
                dtpStartDateNewTask.Visible = true;
                cbProject.Visible = true;
               
                cbProject.Items.AddRange(TaskController.GetListProject().ToArray()  );
            }
        }

        private void txtNameNewTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Task task = new Task();
                task.TaskName = txtNameNewTask.Text;
                task.StartDate = dtpStartDateNewTask.Value;
                task.EndDate = dtpEndDateNewTask.Value;
                //task.IDProject = 0;
                task.IDTask = -1;
                if (cbProject.SelectedIndex == -1)
                {
                    MessageBox.Show("Chưa chọn dự án");
                    return;
                }
                task.IDProject = TaskController.GetListProject()[cbProject.SelectedIndex].IDProject;
                ActiveControl = null;
                TaskController.AddNewTask(task,Employee,this);
                txtNameNewTask.Clear();
                txtNameNewTask.Text = "Thêm công việc mới";

                dtpStartDateNewTask.Visible = false;
                dtpEndDateNewTask.Visible = false;
                label52.Visible = false;
                cbProject.Visible = false;
                cbProject.Items.Clear();
                cbProject.Text = "Project";
                label53.Visible = false;
            }
        }
    }
}
