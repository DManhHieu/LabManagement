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
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            LoginController.IsLogin = false;
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


    }
}
