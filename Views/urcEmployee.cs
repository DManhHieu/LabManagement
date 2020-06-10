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
    public partial class urcEmployee : UserControl
    {
        private int _ID;
        public urcEmployee(int ID)
        {
            InitializeComponent();
            _ID = ID;
            var employee = EmployeeController.GetEmployee(ID);
            FullName = employee.FirstName + " " + employee.LastName;
            Email = employee.Email;
            Position = employee.Position;
            PathAvatar = employee.PathAvatar;
        }
        public Employee Employee
        {
            set
            {
                FullName = value.FirstName + " " + value.LastName;
                Email = value.Email;
                Position = value.Position;
                PathAvatar = value.PathAvatar;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeController.urcEmployee = this;
            frmInfoEmployee thongtin = new frmInfoEmployee(_ID);
            thongtin.Text = "Nhân viên " + FullName;
            mainController.SetView(thongtin);

        }
        private string FullName
        {
            set
            {
                if(value!=null)
                    this.lblName.Text = value.Trim();
            }
            get
            {
                return this.lblName.Text;
            }
        }
        private string Position
        {
            set
            {
                if(value!=null)
                    this.lblPosition.Text = value.Trim();
            }
        }
        private string Email
        {
            set
            {
                if(value!=null)
                    this.linklblEmail.Text = value.Trim();
            }
        }
        private string PathAvatar
        {
            set
            {
                if (value != null)
                {
                    this.picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                    this.picAvatar.ImageLocation = value;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmListTask task = new frmListTask();

        }
    }
}
