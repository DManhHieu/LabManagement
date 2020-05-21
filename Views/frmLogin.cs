using LabManagement.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabManagement.Views
{
    public partial class frmLogin : Form
    {
        private List<User> _users;
        private User _user;
        public frmLogin(ref User user, List<User> users)
        {
            InitializeComponent();
            _user = user;
            _users = users;
        }

        #region Close
        private void lblclose_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }
        #endregion

        private void btnSignin_Click(object sender, EventArgs e)
        {
            //if (txtUserName.Text == "admin" &&txtPassword.Text=="admin")
            //{
            //    IsCheck = true;
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Hãy kiểm tra lại");
            //}
            int index = _users.FindIndex(x => x.Username == txtUserName.Text.Trim() && x.Password == txtPassword.Text.Trim());
            if (index != -1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại");
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == "Username")
                this.txtUserName.Clear();

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.PasswordChar == '\0')
            {
                this.txtPassword.Clear();
                this.txtPassword.PasswordChar = '*';
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == string.Empty)
            {
                txtUserName.Text = "Username";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
            }
        }
    }
}
