using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThanhVien.Controllers;
using QuanLyThanhVien.Models;

namespace QuanLyThanhVien.Views
{
    public partial class urcProject : UserControl
    {
        public urcProject(Project project,frmListProjects frmListProjects)
        {
            InitializeComponent();
            Project = project;
            _frmList = frmListProjects;
        }
        private frmListProjects _frmList;
        private Project _project;
        private Project Project
        {
            get
            {
                return _project;
            }
            set
            {
                _project = value;
                lblNameProject.Text = value.ToString();
                lblStartDate.Text ="Bắt đầu : " +value.StartDate.ToString();
                lblEndDate.Text ="Kết thúc : "+ value.EndDate.ToString();
                pgbComplete.Value = (int)( ProjectController.intComplete(value)*100);
                lblComplete.Text = pgbComplete.Value.ToString() + "%";
                
            }
        }
        private void showinfo(object sender, EventArgs e)
        {
            frmInfoProject infoProject = new frmInfoProject(Project,this,_frmList);
            infoProject.Text = "Thông tin dự án";
            mainController.SetView(infoProject);
        }
    }
}
