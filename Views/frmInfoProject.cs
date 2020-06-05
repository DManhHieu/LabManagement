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
    public partial class frmInfoProject : Form
    {
        public frmInfoProject()
        {
            InitializeComponent();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            frmInfoTask infoTask = new frmInfoTask();
            infoTask.ShowDialog();
        }
    }
}
