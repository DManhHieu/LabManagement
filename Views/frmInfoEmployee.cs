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
      
        public frmInfoEmployee()
        {
            InitializeComponent();
            
            if (EmployeeController.SelectEmployee!=null)
            {
                Employee = EmployeeController.SelectEmployee;
                btnDelete.Visible = !EmployeeController.IsManager;
                txtMaNhanVien.ReadOnly = !mainController.IsManager;
                btnDelete.Visible = !(Employee.IDEmployee == mainController.EmployeeLogin.IDEmployee);
                lblPassword.Visible = Employee.IDEmployee == mainController.EmployeeLogin.IDEmployee;
                txtPassword.Visible = Employee.IDEmployee == mainController.EmployeeLogin.IDEmployee;
                
            }
            else
            {
                _employee.IDEmployee = -1;
                Password = "0000";
            }
         

        }
        private Employee _employee = null;
        public frmInfoEmployee(Employee employee)
        {
            InitializeComponent();

            
            Employee = employee;
            
            btnDelete.Visible = false;
            lblPassword.Visible = true;
            txtMaNhanVien.ReadOnly = !mainController.IsManager;
            txtPassword.Visible = true;
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
                if (_employee == null)
                {
                    _employee = new Employee();
                }
                _employee.UserName = MaNhanVien;
                _employee.FirstName = FirstName;
                _employee.LastName = LastName;
                _employee.Birthday = Birthday;
                _employee.PathAvatar = PathAvatar;
                _employee.CMND = CMND;
                _employee.Address = Address;
                _employee.Position = Position;
                _employee.Email = Email;
                _employee.PhoneNumber = PhoneNumber;
                _employee.Description = Description;
                _employee.StartDate = StartDate;
                _employee.EPassword = Password;
                _employee.IDLAB = IDLab;
                
                return _employee;
            }
            set
            {
                _employee = value;
                MaNhanVien = value.UserName;
                if(value.FirstName!=null)
                FirstName = value.FirstName;
                if(value.LastName!=null)
                LastName = value.LastName;
                if(value.Birthday!=null)
                Birthday = value.Birthday.Value;
                if(value.PathAvatar!=null)
                PathAvatar = value.PathAvatar;
                if(value.CMND!=null)
                CMND = value.CMND;
                if(value.Address!=null)
                Address = value.Address;
                if(value.Email!=null)
                Email = value.Email;
                if(value.EPassword!=null)
                Password = value.EPassword;
                if(value.Position!=null)
                Position = value.Position;
                if(value.PhoneNumber!=null)
                PhoneNumber = value.PhoneNumber;
                if(value.Description!=null)
                Description = value.Description;
                if(value.StartDate!=null)
                    StartDate = value.StartDate.Value;
                if(value.IDLAB!=null)
                    IDLab = (int)value.IDLAB;
            }
        }
        private string Password 
        {
            get 
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value.Trim();
            }
        }
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
            if (EmployeeController.SelectEmployee==null)
            {
                ResetForm();
                return;
            }
            EmployeeController.Delete();
            this.Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            Password = "0000";
        }
    }
}
