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

namespace QuanLyThanhVien.Views
{
    public partial class urcProject : UserControl
    {
        public urcProject()
        {
            InitializeComponent();
        }

        private void showinfo(object sender, EventArgs e)
        {
            frmInfoProject infoProject = new frmInfoProject();

        }
    }
}
