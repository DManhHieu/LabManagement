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
    public partial class urcTaskList : UserControl
    {
        public urcTaskList()
        {
            InitializeComponent();
            for(int i = 0; i < 5; i++)
            {
                urcSubTask subtask = new urcSubTask();
                this.flpListSubTask.Controls.Add(subtask);
            }
        }
        public string TaskName
        {
            get
            {
                return this.lblNameTask.Text;
            }
            set
            {
                this.lblNameTask.Text = value;
            }
        }

        private void lblNameTask_Click(object sender, EventArgs e)
        {
            this.flpListSubTask.Visible = !this.flpListSubTask.Visible;
            this.picExtend.Image = this.flpListSubTask.Visible ?
                Properties.Resources.baseline_keyboard_arrow_up_black_18dp :
                Properties.Resources.baseline_keyboard_arrow_down_black_18dp;
        }
    }
}
