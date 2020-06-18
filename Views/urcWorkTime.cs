using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThanhVien.Models;
using QuanLyThanhVien.Controllers;

namespace QuanLyThanhVien.Views
{
    public partial class urcWorkTime : UserControl
    {
        public urcWorkTime(TimeWork timeWork)
        {
            InitializeComponent();
            TimeWork = timeWork;
            this.dtpStartTime.ValueChanged += dtpChanged;
            this.dtpEndTime.ValueChanged += dtpChanged;
        }
        private TimeWork _time;
        private TimeWork TimeWork
        {
            get
            {
                _time.StartDate = dtpStartTime.Value;
                _time.EndDate = dtpEndTime.Value;
                return _time;
            }
            set
            {
                dtpStartTime.Value = value.StartDate.Value;
                dtpEndTime.Value = value.EndDate.Value;
                _time = value;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            TimeWorkController.Delete(TimeWork);
            this.Dispose();
        }

        private void dtpChanged(object sender, EventArgs e)
        {
            TimeWorkController.UpdateWorkTime(TimeWork);
        }
    }
}
