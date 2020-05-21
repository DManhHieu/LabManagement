using LabManagement.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LabManagement.Views
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
       
            LoadData();
        }
        private User _user;
        private List<User> users;
        private UserControl childcontrol=null;
        private Color ColorIconMenu=Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
        private void LoadData()
        {
            users = new List<User>();
            User user = new User() { Username = "user1", Name = "Đoàn Mạnh Hiếu", Password = "123456",Position="Manager",PathAvatar="D:\\OneDrive\\Pictures\\Saved Pictures\\84a587b01f9ee7c0be8f.jpg"};
            users.Add(user);
            user = new User() { Username = "admin", Name = "Thành viên 2", Password = "admin" };
            users.Add(user);
            user = new User() { Username = "user3", Name = "Thành viên 3" };
            users.Add(user);
            user = new User() { Username = "user4", Name = "Thành viên 4" };
            users.Add(user);
            user = new User() { Username = "user5", Name = "Thành viên 5" };
            users.Add(user);
            user = new User() { Username = "user6", Name = "Thành viên 6" };
            users.Add(user);
            user = new User() { Username = "user7", Name = "Thành viên 7" };
            users.Add(user);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu.Size.Width == 200)
            {
                this.pnlMenu.Size = new Size(50, 681);
            }
            else
            {
                this.pnlMenu.Size = new Size(200, 681);
            }
        }
        private void HideMenu()
        {
            this.pnlDashBoardMenu.BackColor = this.pnlMenu.BackColor;
            this.pnlMyWorkMenu.BackColor = this.pnlMenu.BackColor;
            this.pnlTeamMenu.BackColor = this.pnlMenu.BackColor;
            this.pnlProjectsMenu.BackColor = this.pnlMenu.BackColor;
            this.pnlTimeMenu.BackColor = this.pnlMenu.BackColor;
            this.pnlFinanceMenu.BackColor = this.pnlMenu.BackColor;

        }
        private void btnDashBoardMenu_Click(object sender, EventArgs e)
        {
            //if (childcontrol != null)
            //{
            //    childcontrol.Dispose();
            //}
            //urcDashBoard dashBoard = new urcDashBoard();
            //dashBoard.Dock = DockStyle.Fill;
            //this.pnlActivity.Controls.Add(dashBoard);
            //childcontrol = dashBoard;
            //DesignButtonMenuSelected(this.pnlDashBoardMenu);
            DashBoardMenuLoad();
            //else
            //{
            //    this.pnlDashBoardMenu.BackColor = this.pnlMenu.BackColor;
            //}
        }
      
        private void DashBoardMenuLoad()
        {
            if (childcontrol != null)
            {
                childcontrol.Dispose();
            }
            urcDashBoard dashBoard = new urcDashBoard();
            dashBoard.Dock = DockStyle.Fill;
            this.pnlActivity.Controls.Add(dashBoard);
            childcontrol = dashBoard;
            DesignButtonMenuSelected(this.pnlDashBoardMenu);
        }
        private void btnMyWorkMenu_Click(object sender, EventArgs e)
        {
            DesignButtonMenuSelected(this.pnlMyWorkMenu);
            if (childcontrol is urcMyTask) return;

            if (!(childcontrol is urcMyTask) && childcontrol != null)
            {
                childcontrol.Dispose();
            }
            urcMyTask task= new urcMyTask();
            task.Dock = DockStyle.Fill;
            this.pnlActivity.Controls.Add(task);
            childcontrol = task;
         
            //else
            //{
            //    this.pnlMyWorkMenu.BackColor = this.pnlMenu.BackColor;
            //}
        }

        private void btnTeamMenu_Click(object sender, EventArgs e)
        {
            DesignButtonMenuSelected(this.pnlTeamMenu);
            if (childcontrol is urcTeam) return;

            if (!(childcontrol is urcTeam)&&childcontrol!=null)
            {
                childcontrol.Dispose();
            }
            urcTeam team = new urcTeam(this.users);
            team.Dock = DockStyle.Fill;
            this.pnlActivity.Controls.Add(team);
            childcontrol = team;
            //DesignButtonMenuSelected(this.pnlTeamMenu);
            //{
            //    this.pnlTeamMenu.BackColor = this.pnlMenu.BackColor;
            //}
        }
        private void btnProjectsMenu_Click(object sender, EventArgs e)
        {
            DesignButtonMenuSelected(this.pnlProjectsMenu);
            if (childcontrol is urcProjects) return;

            if (!(childcontrol is urcProjects) && childcontrol != null)
            {
                childcontrol.Dispose();
            }
            urcProjects projects = new urcProjects();
            projects.Dock = DockStyle.Fill;
            this.pnlActivity.Controls.Add(projects);
            childcontrol = projects;
            //DesignButtonMenuSelected(this.pnlProjectsMenu);
            //else
            //{
            //    this.pnlProjectsMenu.BackColor = this.pnlMenu.BackColor;
            //}
        }

        private void btnTimeMenu_Click(object sender, EventArgs e)
        {
            DesignButtonMenuSelected(this.pnlTimeMenu);
            //else
            //{
            //    this.pnlTimeMenu.BackColor = this.pnlMenu.BackColor;
            //}
        }

        private void DesignButtonMenuSelected(Panel panelicon)
        {
            HideMenu();
            panelicon.BackColor = ColorIconMenu;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(ref _user, users);
            frmLogin.ShowDialog();
            //DesignButtonMenuSelected(this.pnlDashBoardMenu);
            DashBoardMenuLoad();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBudgetMenu_Click(object sender, EventArgs e)
        {
            DesignButtonMenuSelected(this.pnlFinanceMenu);
        }




        //private Form activiForm = null;
        //private void OpenChildForm(Form childForm)
        //{
        //    if (activiForm != null)
        //        activiForm.Close();
        //    activiForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.Dock = DockStyle.Fill;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    pnlChildActivy.Controls.Add(childForm);
        //    pnlChildActivy.Tag = childForm;
        //    pnlChildActivy.BringToFront();
        //    childForm.Show();
        //}
        //private void Button_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new frmUser(((Button)sender).Tag));
        //}

    }
}
