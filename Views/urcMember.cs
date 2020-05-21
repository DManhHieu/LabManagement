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
    public partial class urcMember : UserControl
    {
        private urcTeam _parent;
        //public static Color BackColorDefault= Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
        //public static Color BackColorSelected= Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
        public urcMember(urcTeam Parent,User user)
        {
            InitializeComponent();
            _parent = Parent;
            Fullname = user.Name;
            pathAvatar = user.PathAvatar;
            position = user.Position;
            UserName = user.Username;
            //pathAvatar= "D:\\OneDrive\\Pictures\\Saved Pictures\\84a587b01f9ee7c0be8f.jpg";
        }

        private void FullName_Click(object sender, EventArgs e)
        {
            MemberClick(sender, e);
        }
        public void MemberClick(object sender,EventArgs e)
        {
            //frmUser user = new frmUser();
            //user.FullName = Fullname;
            //user.PathImage = pathAvatar;
            //user.Positon = position;
            //user.ShowDialog();
           
            _parent.SetView(this);
            this.Focus();


        }
        public string Fullname 
        {
            get { return this.lblName.Text; }
            set { this.lblName.Text = value; }
        }
        public string UserName { get; set; }
        public string position 
        {
            get 
            { 
                return this.lblPosition.Text;
            }
            set
            {
                this.lblPosition.Text = value;
            }
        }
        public string pathAvatar
        {
            get
            {
                return this.picAvatar.ImageLocation;
            }
            set
            {
                this.picAvatar.ImageLocation = value;
            }
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            MemberClick(sender, e);
        }
        //public override Color BackColor
        //{
        //    get
        //    {
        //        return this.pnlTitle.BackColor;
        //    }
        //    set
        //    {
        //        this.pnlTitle.BackColor = value;
        //    }
        //}
    }
}
