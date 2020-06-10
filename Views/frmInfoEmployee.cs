using QuanLyThanhVien.Controllers;
using QuanLyThanhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.Views
{
    public partial class frmInfoEmployee : Form
    {
      
        public frmInfoEmployee(int id)
        {
            InitializeComponent();
            ID = id;
            IDLab = LoginController.IDLab;
            Password = "0";
            if (ID != -1)
            {
                Employee = EmployeeController.GetEmployee(ID);
            }


        }
        //public void SetEmployee(Employee employee)
        //{
        //    MaNhanVien = employee.UserName;
        //    FirstName = employee.FirstName;
        //    LastName = employee.LastName;
        //    Birthday = employee.Birthday.Value;
        //    PathAvatar = employee.PathAvatar;
        //    CMND = employee.CMND;
        //    Address = employee.Address;
        //    Email = employee.Email;
        //    Position = employee.Position;
        //    PhoneNumber = employee.PhoneNumber;
        //    Description = employee.Description;
        //    StartDate = employee.StartDate.Value;

        
        public Employee Employee
        {
            get
            {
                Employee employee = new Employee();
                employee.IDEmployee = ID;
                employee.UserName = MaNhanVien;
                employee.FirstName = FirstName;
                employee.LastName = LastName;
                employee.Birthday = Birthday;
                employee.PathAvatar = PathAvatar;
                employee.CMND = CMND;
                employee.Address = Address;
                employee.Position = Position;
                employee.Email = Email;
                employee.PhoneNumber = PhoneNumber;
                employee.Description = Description;
                employee.StartDate = StartDate;
                employee.EPassword = Password;
                employee.IDLAB = IDLab;
                return employee;
            }
            set
            {
                ID = value.IDEmployee;
                MaNhanVien = value.UserName;
                FirstName = value.FirstName;
                LastName = value.LastName;
                Birthday = value.Birthday.Value;
                PathAvatar = value.PathAvatar;
                CMND = value.CMND;
                Address = value.Address;
                Email = value.Email;
                Password = value.EPassword;
                Position = value.Position;
                PhoneNumber = value.PhoneNumber;
                Description = value.Description;
                StartDate = value.StartDate.Value;
                if(value.IDLAB!=null)
                    IDLab = (int)value.IDLAB;
            }
        }
        private int ID { get; set; }
        private string Password { get; set; }
        private int IDLab { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string MaNhanVien
        {
            get
            {
                return txtMaNhanVien.Text;
            }
            set
            {
                txtMaNhanVien.Text = value.Trim();
            }
        }
        private string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
            set
            {
                txtFirstName.Text = value.Trim();
            }
        }
        private string LastName
        {
            get
            {
                return txtLastName.Text;
            }
            set
            {
                txtLastName.Text = value.Trim();
            }
        }
        private DateTime Birthday
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
        private string PathAvatar
        {
            get
            {
                return picAvatar.ImageLocation;
            }
            set
            {
                if (value != null)
                {
                    picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                    picAvatar.ImageLocation = value.Trim();
                }
            }
        }
        private string CMND
        {
            get
            {
                return txtCMND.Text;
            }
            set
            {
                if (value != null)
                {
                    txtCMND.Text = value.ToString();
                }
            }
        }
        private string Email
        {
            get
            {
                return txtEmail.Text;
            }
            set
            {
                if (value != null)
                {
                    txtEmail.Text = value.Trim();
                }
            }
        }
        private string Position
        {
            get
            {
                return txtPosition.Text;

            }
            set
            {
                if (value != null)
                {
                    txtPosition.Text = value.Trim();
                }
            }
        }
        private string PhoneNumber
        {
            get
            {
                return txtPhoneNumber.Text;
            }
            set
            {
                if (value != null)
                {
                    txtPhoneNumber.Text = value.Trim();
                }
            }
        }
        private DateTime StartDate
        {
            get
            {
                return dtpStartDate.Value;
            }
            set
            {
                if (value != null)
                {
                    dtpStartDate.Value = value;
                }
            }
        }
        private string Description
        {
            get
            {
                return rtDescription.Text;
            }
            set
            {
                if (value != null)
                {
                    rtDescription.Text = value.Trim();
                }
            }
        }
        private string Address
        {
            get
            {
                return txtAddress.Text;
            }
            set
            {
                if (value != null)
                {
                    txtAddress.Text = value.Trim();
                }
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
                    PathAvatar = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetForm()
        {
            txtMaNhanVien.Clear();
            txtFirstName.Clear();
            dtpBirthday.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            txtLastName.Clear();
            txtCMND.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtPosition.Clear();
            rtDescription.Clear();
            this.picAvatar.Image = global::QuanLyThanhVien.Properties.Resources.baseline_add_photo_alternate_black_48dp;
            this.picAvatar.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeController.AddorUpdate(Employee);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == -1)
            {
                ResetForm();
                return;
            }
            EmployeeController.Delete(ID);
            this.Close();
        }
    }
}
