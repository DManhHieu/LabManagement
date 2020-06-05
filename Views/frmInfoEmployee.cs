using QuanLyThanhVien.Controller;
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
    public partial class frmInfoEmployee : Form
    {
        public frmInfoEmployee(Employee employee)
        {
            InitializeComponent();
            if(employee != null)
            {
                MaNhanVien = employee.MaNhanVien;
                FirstName = employee.FirstName;
                LastName = employee.LastName;
                Birthday = employee.BirthDay;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string MaNhanVien 
        {
            get
            {
                return txtMaNhanVien.Text;
            }
            set
            {
                txtMaNhanVien.Text = value;
            }
        }
        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
            set
            {
                txtFirstName.Text = value;
            }
        }
        public string LastName
        {
            get
            {
                return txtLastName.Text;
            }
            set
            {
                txtLastName.Text = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return dtpBirthday.Value;
            }
            set
            {
                dtpBirthday.Value = value;
            }
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                    picAvatar.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeController.AddNewEmployee(new Employee());
            this.Close();
        }
    }
}
