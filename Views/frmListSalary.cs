using QuanLyThanhVien.Controllers;
using QuanLyThanhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyThanhVien.Views
{

    public partial class frmListSalary : Form
    {
        BindingSource source;
        public frmListSalary()
        {
            InitializeComponent();
            dataSalary.AutoGenerateColumns = false;
            source = new BindingSource();
            source.DataSource = SalaryController.getListSalary();
            dataSalary.DataSource = source;
        }

        private void Source_AddingNew(object sender, AddingNewEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dataSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";
            for (int i = 1; i < dataSalary.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataSalary.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataSalary.Rows.Count-1; i++)
            {
                for (int j = 0; j < dataSalary.Columns.Count ; j++)
                {
                    if (j == 9)
                    {
                        if (dataSalary.Rows[i].Cells[j].Value == null)
                        {
                            worksheet.Cells[i + 2, j + 1] = "False";
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = dataSalary.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = dataSalary.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            worksheet.Columns.AutoFit();
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void dataSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
         
        }


        private void dataSalary_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataSalary.Rows[e.RowIndex].Cells["cMonth"].Value != null)
            {
                dataSalary.Rows[e.RowIndex].Cells["cTongLuong"].Value = Convert.ToInt32(dataSalary.Rows[e.RowIndex].Cells["cLuongCoBan"].Value) - Convert.ToInt32(dataSalary.Rows[e.RowIndex].Cells["cPhat"].Value) + Convert.ToInt32(dataSalary.Rows[e.RowIndex].Cells["cThuong"].Value);
                dataSalary.Rows[e.RowIndex].Cells["cLuongConThieu"].Value = Convert.ToInt32(dataSalary.Rows[e.RowIndex].Cells["cTongLuong"].Value) - Convert.ToInt32(dataSalary.Rows[e.RowIndex].Cells["cLuongDaNhan"].Value);   
            }
            if (Convert.ToInt32(dataSalary.Rows[e.RowIndex].Cells["cLuongConThieu"].Value) == 0)
            {
                dataSalary.Rows[e.RowIndex].Cells["cNhanDu"].Value = true;
            }
            else
            {
                dataSalary.Rows[e.RowIndex].Cells["cNhanDu"].Value = false;
            }
        }

        private void dataSalary_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cLocDuLieu_Click(object sender, EventArgs e)
        {
            DateTime month = Convert.ToDateTime(dtpLocDulieu.Value.ToString());
            dataSalary.AutoGenerateColumns = false;
            source = new BindingSource();
            source.DataSource = SalaryController.getSalary(month);
            dataSalary.DataSource = source;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved_1(object sender, SplitterEventArgs e)
        {

        }

        private void frmListSalary_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataSalary.Rows.Count - 1; i++)
            {
                this.dataSalary.Rows[i].Cells[5].Value = Convert.ToInt32(this.dataSalary.Rows[i].Cells[2].Value) - Convert.ToInt32(this.dataSalary.Rows[i].Cells[3].Value) + Convert.ToInt32(this.dataSalary.Rows[i].Cells[4].Value);
                this.dataSalary.Rows[i].Cells[7].Value = Convert.ToInt32(this.dataSalary.Rows[i].Cells[5].Value) - Convert.ToInt32(this.dataSalary.Rows[i].Cells[6].Value);
            }
        }
        private void dataSalary_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void dataSalary_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Salary salary = new Salary();
            List<Employee> employee = SalaryController.GetIDEmployee(Convert.ToInt32(this.dataSalary.CurrentRow.Cells[0].Value));
            if (employee == null)
            {
                MessageBox.Show("Không tồn tại ID này ! Yêu cầu nhập lại ","Lỗi");
                this.dataSalary.CurrentRow.Cells[0].Value = 0;
                return;
            }    
            else
                salary.IDEmployee = Convert.ToInt32(this.dataSalary.CurrentRow.Cells[0].Value);
            DateTime t = Convert.ToDateTime(this.dataSalary.CurrentRow.Cells[8].Value);
            if (t.Year == 1)
            {
                MessageBox.Show("Bạn chưa nhập Tháng Năm","Thông báo");
                return;
            }
            else
                salary.Month = Convert.ToDateTime(this.dataSalary.CurrentRow.Cells[8].Value.ToString());
            Salary salarys = SalaryController.getSalary(Convert.ToInt32(this.dataSalary.CurrentRow.Cells[0].Value), Convert.ToDateTime(this.dataSalary.CurrentRow.Cells[8].Value));
            if (e.ColumnIndex == 8 || e.ColumnIndex==0)
            {
                if (salarys != null)
                {
                    MessageBox.Show("Trùng dữ liệu","Lỗi");
                    source.DataSource = SalaryController.getListSalary();
                    return;
                }
            }
            salary.UserName = employee[0].UserName.ToString();
            if (this.dataSalary.CurrentRow.Cells[2].Value is null)
                salary.LuongCoBan = 0;
            else salary.LuongCoBan = Convert.ToInt32(this.dataSalary.CurrentRow.Cells[2].Value);
            if (this.dataSalary.CurrentRow.Cells[3].Value is null)
                salary.Phat = 0;
            else salary.Phat = Convert.ToInt32(this.dataSalary.CurrentRow.Cells[3].Value);
            if (this.dataSalary.CurrentRow.Cells[4].Value is null)
                salary.Thuong = 0;
            else salary.Thuong = Convert.ToInt32(this.dataSalary.CurrentRow.Cells[4].Value);
            if (this.dataSalary.CurrentRow.Cells[6].Value is null)
                salary.LuongDaNhan = 0;
            else salary.LuongDaNhan = Convert.ToInt32(this.dataSalary.CurrentRow.Cells[6].Value);
            this.dataSalary.AutoGenerateColumns = false;
            SalaryController.UpdateSalary(salary);
            source.DataSource = SalaryController.getListSalary();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Resest_Click(object sender, EventArgs e)
        {
            dataSalary.AutoGenerateColumns = false;
            source = new BindingSource();
            source.DataSource = SalaryController.getListSalary();
            dataSalary.DataSource = source;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.dataSalary.SelectedRows.Count<=0)
            {
                return;
            }
            string message = "Bạn chắc chắn muốn xóa ?";
            string title = "Delete salary";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Salary salary = SalaryController.getSalary(Convert.ToInt32(this.dataSalary.SelectedRows[0].Cells[0].Value), Convert.ToDateTime(this.dataSalary.SelectedRows[0].Cells[8].Value));
                SalaryController.DeleteSalary(salary);
                dataSalary.AutoGenerateColumns = false;
                source = new BindingSource();
                source.DataSource = SalaryController.getListSalary();
                dataSalary.DataSource = source;
            }
            else
            {
                return;
            }
        }
    }
}

