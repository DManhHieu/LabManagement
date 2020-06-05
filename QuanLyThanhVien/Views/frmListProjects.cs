using QuanLyThanhVien.Controller;
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
    public partial class frmListProjects : Form
    {
        public frmListProjects()
        {
            InitializeComponent();
        }

      

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            frmInfoProject add = new frmInfoProject();
            add.Text = "Thêm dự án";
            testcontroller.SetViewForm1(add);
        }
    }
}
