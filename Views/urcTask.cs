using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThanhVien.Models;
using QuanLyThanhVien.Controllers;

namespace QuanLyThanhVien.Views
{
    public partial class urcTask : UserControl
    {
        private Task _task;
        private frmListTask _frmListTask;
        private frmInfoProject _infoPorject;
        public urcTask(Task task,frmListTask frmListTask)
        {
            InitializeComponent();
            this.Click += InfoTask;
            lblTaskName.Click += InfoTask;
            _frmListTask = frmListTask;
            Task = task;
        }
        public urcTask(Task task, frmInfoProject infoProject)
        {
            InitializeComponent();
            this.Click += InfoTaskProject_Click;
            lblTaskName.Click += InfoTaskProject_Click;
            _infoPorject = infoProject;
            Task = task;

        }

        private void InfoTaskProject_Click(object sender, EventArgs e)
        {

            frmInfoTask infoTask = new frmInfoTask(_task, _infoPorject, this);
            infoTask.ShowDialog();
        }

        private Task Task
        {
            get
            {
                return _task;
            }
            set
            {
                _task = value;
                lblTaskName.Text = value.TaskName;
                lblStartDate.Text = value.StartDate.ToString();
                lblEndDate.Text = value.EndDate.ToString();
                if (TaskController.GetProject(value) != null)
                    lblProjectName.Text = TaskController.GetProject(value).ToString();
                if (value.Status == true.ToString())
                    cbComplete.Checked = true;
            }
        }
        private void InfoTask(object sender, EventArgs e)
        {

            frmInfoTask infoTask = new frmInfoTask(_task,_frmListTask,this);
            infoTask.ShowDialog();
        }
        private void cbComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbComplete.Checked.ToString() != _task.Status) 
            {
                _task.Status = cbComplete.Checked.ToString();
                _task.Employees = TaskController.GetListEmployee(_task);
                TaskController.AddOrUpdateTask(_task);
            }
         
        
            //
            //this.Dispose();

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            TaskController.Delete(_task,this);
        }
    }
}
