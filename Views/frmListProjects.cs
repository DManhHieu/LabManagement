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
    public partial class frmListProjects : Form
    {
        public frmListProjects()
        {
            InitializeComponent();
            ProjectController.LoadList(this);
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            frmInfoProject add = new frmInfoProject(this);
            add.Text = "Thêm dự án";
            mainController.SetView(add);
        }
        public void AddToDo(Project project)
        {
            urcProject urcProject = new urcProject(project,this);
            flpListProjectToDo.Controls.Add(urcProject);

        }
        public void AddDoing(Project project)
        {
            urcProject urcProject = new urcProject(project,this);
            flpListProjectDoing.Controls.Add(urcProject);

        }
        public void AddComplete(Project project)
        {
            urcProject urcProject = new urcProject(project,this);
            flpListProjectComplete.Controls.Add(urcProject);

        }
    }
}
