using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagement.Views
{
    public partial class urcMyTask : UserControl
    {
        public urcMyTask()
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
            {
                urcTaskList task = new urcTaskList();
                task.TaskName = $"Công việc {i}";

                this.flpListTask.Controls.Add(task);
            }
        }
    }

        //private void label43_Click(object sender, EventArgs e)
        //{
        //    this.pnlSubTasks.Visible = !this.pnlSubTasks.Visible;
        //}
}
