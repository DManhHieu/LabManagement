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
    public partial class urcProjects : UserControl
    {
        public urcProjects()
        {
            InitializeComponent();
            for(int i = 0; i < 20; i++)
            {
                urcProject project = new urcProject();
                project.Click += project_click;
                this.flpListProject.Controls.Add(project);
            }
        }
        private void project_click(object sender,EventArgs e)
        {
            MessageBox.Show("AAA");
        }
    }
}
