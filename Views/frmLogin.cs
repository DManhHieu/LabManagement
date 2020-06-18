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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            LoginController.IsLogin = false;
            this.FormClosed += FrmLogin_FormClosed;
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LoginController.IsLogin == false)
                Application.Exit();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if (LoginController.Login(UserName, Password))
                this.Close();
            else
            {
                MessageBox.Show("Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private string UserName
        {
            get
            {
                return txtUserName.Text;
            }
        }
        private string Password
        {
            get
            {
                return txtPassword.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCreateLab frmCreateLab = new frmCreateLab();
            frmCreateLab.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này có thời gian mới làm");
        }
    }
}
