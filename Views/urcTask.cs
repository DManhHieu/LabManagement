using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.Views
{
    public partial class urcTask : UserControl
    {
        public urcTask()
        {
            InitializeComponent();
           
        }

        private void InfoTask(object sender, EventArgs e)
        {
            frmInfoTask infoTask = new frmInfoTask();
            infoTask.ShowDialog();
        }
    }
}
