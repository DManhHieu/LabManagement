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
    public partial class frmMain : Form
    {
        private List<Form> activity = new List<Form> { };
        public frmMain()
        {
            InitializeComponent();
            mainController._main = this;
            this.FormClosed += FrmMain_FormClosed;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ResetMenu()
        {
            this.lblControl.Text = "Xin chào " + mainController.EmployeeLogin.ToString();
            this.pnlRimDashBoard.BackColor = this.pnlMenu.BackColor;
            this.pnlRimEmployees.BackColor = this.pnlMenu.BackColor;
            this.pnlRimProject.BackColor = this.pnlMenu.BackColor;
            this.pnlRimTime.BackColor = this.pnlMenu.BackColor;
            this.pnlRimSalary.BackColor = this.pnlMenu.BackColor;
            this.pnlRimProfile.BackColor = this.pnlMenu.BackColor;
            this.activity.Clear();
            this.pnlActivity.Controls.Clear();
        }
        public void SetView(Form form)
        {
           
            if (activity.Count > 0)
            {
                activity.Last().Visible = false;
            }
            
            form.TopLevel = false;
            this.lblControl.Text = form.Text;
            form.Dock = DockStyle.Fill;
            form.FormClosed += Form_FormClosed;
            this.pnlActivity.Controls.Add(form);
            this.activity.Add(form);
            form.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (activity.Count != 0)
            {
                this.activity.RemoveAt(activity.Count - 1);
                if (activity.Count != 0)
                {
                    this.activity.Last().Visible = true;
                    this.lblControl.Text = this.activity.Last().Text;
                }

            }
            if(activity.Count== 0)
            {
                ResetMenu();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu.Width == 170)
            {
                this.pnlMenu.Width = 44;
            }
            else
            {
                this.pnlMenu.Width = 170;
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (this.pnlRimEmployees.BackColor == Color.Blue)
            {
                return;
            }
            ResetMenu();
            this.pnlRimEmployees.BackColor = Color.Blue;
            frmEmployees thanhvien = new frmEmployees();
            thanhvien.Text = "Danh sách nhân viên";
            SetView(thanhvien);
        }
        
        private void btnSalary_Click(object sender, EventArgs e)
        {
           
            if (this.pnlRimSalary.BackColor == Color.Blue)
            {
                return;
            }

            ResetMenu();
            this.pnlRimSalary.BackColor = Color.Blue;
            //this.lblControl.Text = "Bảng lương";
            frmListSalary bangLuong = new frmListSalary();
            bangLuong.Text = "Bảng lương";
            SetView(bangLuong);
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            if (this.pnlRimTime.BackColor == Color.Blue)
            {
                return;
            }
            ResetMenu();
            this.pnlRimTime.BackColor = Color.Blue;
            //this.lblControl.Text = "Bảng lương";
            frmTime time = new frmTime();
            time.Text = "Thời gian làm việc";
            SetView(time);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            if (this.pnlRimProject.BackColor == Color.Blue)
            {
                return;
            }
            ResetMenu();
            this.pnlRimProject.BackColor = Color.Blue;
            frmListProjects listProjects = new frmListProjects();
            listProjects.Text = "Các dự án";
            SetView(listProjects);
        }
        public static Employee _employee;
        private void frmMain_Load(object sender, EventArgs e)
        {

            Login();
            //EmployeeController.IsManager(_employee.IDEmployee);
            //this.lblLabName.Text = mainController.LabName(_employee);

        }
        private void Login()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (!LoginController.IsLogin)
            {
                this.Close();
                return;
            }

            this.lblControl.Text = "Xin chào " + mainController.EmployeeLogin.ToString();
            this.lblLabName.Text = mainController.Lab.LabName;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //Login();
            //if (!LoginController.IsLogin) return;
            this.Visible = false;
            frmMain NewfrmMain = new frmMain();
            NewfrmMain.Show();
            this.Dispose(false);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (this.pnlRimProfile.BackColor == Color.Blue)
            {
                return;
            }
            ResetMenu();
            this.pnlRimProfile.BackColor = Color.Blue;
            EmployeeController.SelectID = mainController.EmployeeLogin.IDEmployee;
            EmployeeController.urcEmployee = null;
            frmInfoEmployee info = new frmInfoEmployee();

            info.Text = "Thông tin cá nhân ";
            SetView(info);
        }
    }
}
