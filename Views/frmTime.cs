using QuanLyThanhVien.Controllers;
using QuanLyThanhVien.Models;
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
    public partial class frmTime : Form
    {
        public frmTime()
        {
            InitializeComponent();
            Monday = DateTime.Now.Date;
        }
        private DateTime _monday;
        private DateTime Monday
        {
            get
            {
                return _monday;
            }
            set
            {
                _monday = value.AddDays(-(int)value.DayOfWeek + 1 );
                dtpDateSelect.Value = _monday;
                lblWeek.Text = _monday.ToString("dd/MM") + "-" + _monday.AddDays(6).ToString("dd/MM/yyyy");
                this.flpListWorkTime.Controls.Clear();
                TimeWorkController.LoadList(this);
            }
        }

        private void frmTime_Load(object sender, EventArgs e)
        {
            //TimeWorkController.LoadList(this);
        }
        public void AddTime(Employee employee)
        {
            urcTime urcTime = new urcTime(employee, Monday);
            this.flpListWorkTime.Controls.Add(urcTime);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Monday = Monday.AddDays(-7);
          
           
            //this.flpListWorkTime.Controls.Clear();
            //TimeWorkController.LoadList(this);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Monday = Monday.AddDays(7);
            //this.flpListWorkTime.Controls.Clear();
            //TimeWorkController.LoadList(this);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            Monday = DateTime.Now;
            //this.flpListWorkTime.Controls.Clear();
            //TimeWorkController.LoadList(this);
        }


        private void dtpDateSelect_CloseUp(object sender, EventArgs e)
        {
            if(Monday!=dtpDateSelect.Value)
                Monday = dtpDateSelect.Value;
        }
    }
}
