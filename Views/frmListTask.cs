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
    public partial class frmListTask : Form
    {
        public frmListTask()
        {
            InitializeComponent();
        }

        private void frmTask_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.flpExpired.Visible = !this.flpExpired.Visible;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            this.flpDoing.Visible = !this.flpDoing.Visible;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmInfoTask infoTask = new frmInfoTask();
            infoTask.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
