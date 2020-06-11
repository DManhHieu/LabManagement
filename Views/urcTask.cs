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
        private Task Task;
        public urcTask(Task task)
        {
            InitializeComponent();
            Task = task;
            lblTaskName.Text = task.TaskName;
            lblStartDate.Text = task.StartDate.ToString();
            lblEndDate.Text = task.EndDate.ToString();
            if (task.Status == true.ToString())
                cbComplete.Checked = true;
           
        }

        private void InfoTask(object sender, EventArgs e)
        {
            frmInfoTask infoTask = new frmInfoTask(Task);
            infoTask.ShowDialog();
        }

        private void cbComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbComplete.Checked.ToString() != Task.Status) 
            {
                Task.Status = cbComplete.Checked.ToString();
                TaskController.AddOrUpdateTask(Task);
                this.Dispose();
            }
         
        
            //
            //this.Dispose();

        }
    }
}
