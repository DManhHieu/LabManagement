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
    public partial class urcTime : UserControl
    {
        public urcTime()
        {
            InitializeComponent();
        }

        private void Settime_Click(object sender, EventArgs e)
        {
            frmSetTime setTime = new frmSetTime();
            setTime.ShowDialog();
        }
    }
}
