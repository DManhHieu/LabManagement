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
    public partial class urcDashBoard : UserControl
    {
        public urcDashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

            chartProject.Series["Project"].Points.AddXY("Hoàn thành", "10");
           
            chartProject.Series["Project"].Points.AddXY("Chưa làm ", "4");
            chartProject.Series["Project"].Points.AddXY("Quá hạn ", "3");

        }
    }
}
