using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabManagement.Model;

namespace LabManagement.Views
{
    public partial class urcTeam : UserControl
    {
        private List<User> _users;
        public urcTeam(List<User> users)
        {
            InitializeComponent();
            _users = users;

            foreach(User user in _users)
            {
                urcMember urcMember = new urcMember(this,user);
                this.fLpMembers.Controls.Add(urcMember);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //frmUser user = new frmUser();

            //user.ShowDialog();
            if (userview == null || userview.IsDisposed == true)
            {
                urcUserView user = new urcUserView();
            
                this.pnlUserView.Controls.Add(user);

                userview = user;
            }
            //this.pnlUserView.Controls.Clear();
            else
            {
                //urcUserView user = new urcUserView();
                userview.FullName = string.Empty;
                userview.PathImage =string.Empty;
                userview.Positon = string.Empty;

            }
            if (selectedMember != null)
            {
                //selectedMember.BackColor = urcMember.BackColorDefault;
            }

        }
        private urcMember selectedMember=null;
        private urcUserView userview = null;
        public void SetView(urcMember member)
        {
            if (selectedMember == member)
            {
                userview.Dispose();
                //selectedMember.BackColor = urcMember.BackColorDefault;
                selectedMember = null;
                return;
            }
            if (userview == null||userview.IsDisposed==true)
            {
                urcUserView user = new urcUserView();
                user.FullName = member.Fullname;
                user.PathImage = member.pathAvatar;
                user.Positon = member.position;
                this.pnlUserView.Controls.Add(user);
              
                userview = user;
            }
            //this.pnlUserView.Controls.Clear();
            else
            {
                //urcUserView user = new urcUserView();
               userview.FullName = member.Fullname;
               userview.PathImage = member.pathAvatar;
                userview.Positon = member.position;
             
            }
            if (selectedMember != null)
            {
                //selectedMember.BackColor = urcMember.BackColorDefault;
            }
            selectedMember = member;
            //selectedMember.BackColor = urcMember.BackColorSelected;
        }
    }
}
