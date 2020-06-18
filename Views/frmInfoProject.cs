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
    public partial class frmInfoProject : Form
    {
        public frmInfoProject(Project project,urcProject urcProject,frmListProjects frmList)
        {
            InitializeComponent();
            Project = project;
            _urcProject = urcProject;
            _frmList = frmList;
            txtSearchEmployee.TextChanged += TxtSearchEmployee_TextChanged;
            ProjectController.LoadListTask(Project,this);
        }

        private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            lbSearchEmployees.Visible = true;
            this.lbSearchEmployees.Items.Clear();
            foreach(Employee em in EmployeeController.ListEmployee(txtSearchEmployee.Text))
            {
                this.lbSearchEmployees.Items.Add(em);
            }
        }
        private int IDEmployee;
        private frmListProjects _frmList;
        private urcProject _urcProject;
        private bool IsNew = false;
        public frmInfoProject(frmListProjects frmListProjects)
        {
            InitializeComponent();
            _frmList = frmListProjects;
            IsNew = true;
            _urcProject = null;
            cbStatus.SelectedIndex = 0;
            txtSearchEmployee.TextChanged += TxtSearchEmployee_TextChanged;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Project _project=null;
        public Project Project
        {
            get
            {
                if (_project == null) _project = new Project();
                _project.ProjectName = txtProjectName.Text;
                _project.StartDate = dtpStartDate.Value;
                _project.EndDate = dtpEndDate.Value;
                _project.Description = rtDescription.Text;
                _project.Status = cbStatus.SelectedIndex.ToString();
                _project.IDManager = IDEmployee;
                return _project;
            }
            set
            {
                txtProjectName.Text = value.ProjectName;
                if(ProjectController.GetManager(value)!=null)
                    txtSearchEmployee.Text = ProjectController.GetManager(value).ToString();
                rtDescription.Text = value.Description;
                dtpStartDate.Value = value.StartDate.Value;
                dtpEndDate.Value = value.EndDate.Value;
                cbStatus.SelectedIndex = int.Parse(value.Status);
                _project = value;
            }
        }
        public void AddTask(Task task)
        {
            urcTask urcTask = new urcTask(task,this);
            flpListTask.Controls.Add(urcTask);
        }

        private void txtTaskName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (IsNew)
                {
                    ProjectController.Add(Project, _frmList);
                    IsNew = false;
                    Project = ProjectController._project;
                }
                Task task = new Task();
                task.TaskName = txtTaskName.Text;
                task.StartDate = dtpTaskStartDate.Value;
                task.EndDate = dtpTaskEndDate.Value;
                task.IDProject = Project.IDProject;
                TaskController.AddNewTask(task, this);
                txtTaskName.Text = "Thêm công việc";

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProjectController.Delete(Project);
            _urcProject.Dispose();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsNew)
                ProjectController.Add(Project, _frmList);
            else ProjectController.Update(Project, _frmList, _urcProject);
            this.Close();
        }

        private void lbSearchEmployees_Leave(object sender, EventArgs e)
        {
            lbSearchEmployees.Visible = false;
        }

        private void lbSearchEmployees_DoubleClick(object sender, EventArgs e)
        {
            IDEmployee = EmployeeController.ListEmployee(txtSearchEmployee.Text)[lbSearchEmployees.SelectedIndex].IDEmployee;
            txtSearchEmployee.Text = EmployeeController.ListEmployee(txtSearchEmployee.Text)[lbSearchEmployees.SelectedIndex].ToString();
            lbSearchEmployees.Visible = false;
        }
    }
}
