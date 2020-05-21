using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagement.Views
{
    public partial class urcUserView : UserControl
    {
        public urcUserView()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                    picAvatar.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string FullName
        {
            get
            {
                return txtFullName.Text;
            }
            set
            {
                txtFullName.Text = value;
            }
        }
        public string PathImage
        {
            get
            {
                return picAvatar.ImageLocation;
            }
            set
            {
                picAvatar.ImageLocation = value;
            }
        }
        public string Positon
        {
            get
            {
                return txtPosition.Text;
            }
            set
            {
                txtPosition.Text = value;
            }
        }
    }
}
