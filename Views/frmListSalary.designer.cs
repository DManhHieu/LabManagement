using System;
using System.Windows.Forms;

namespace QuanLyThanhVien.Views
{
    partial class frmListSalary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Resest = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.cLocDuLieu = new System.Windows.Forms.Button();
            this.dtpLocDulieu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSalary = new System.Windows.Forms.DataGridView();
            this.cMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuongDaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuongConThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhanDu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.Resest);
            this.splitContainer1.Panel1.Controls.Add(this.btnXuatExcel);
            this.splitContainer1.Panel1.Controls.Add(this.cLocDuLieu);
            this.splitContainer1.Panel1.Controls.Add(this.dtpLocDulieu);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataSalary);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint_1);
            this.splitContainer1.Size = new System.Drawing.Size(907, 525);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::QuanLyThanhVien.Properties.Resources.Editing_Delete_icon;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(518, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Resest
            // 
            this.Resest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resest.Image = global::QuanLyThanhVien.Properties.Resources.Reset_icon;
            this.Resest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Resest.Location = new System.Drawing.Point(656, 22);
            this.Resest.Name = "Resest";
            this.Resest.Size = new System.Drawing.Size(103, 42);
            this.Resest.TabIndex = 4;
            this.Resest.Text = "Reset";
            this.Resest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Resest.UseVisualStyleBackColor = true;
            this.Resest.Click += new System.EventHandler(this.Resest_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = global::QuanLyThanhVien.Properties.Resources.excel_xls_icon;
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(792, 22);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(153, 42);
            this.btnXuatExcel.TabIndex = 3;
            this.btnXuatExcel.Text = "Xuất ExCel";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // cLocDuLieu
            // 
            this.cLocDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLocDuLieu.Image = global::QuanLyThanhVien.Properties.Resources.search_icon;
            this.cLocDuLieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cLocDuLieu.Location = new System.Drawing.Point(337, 22);
            this.cLocDuLieu.Name = "cLocDuLieu";
            this.cLocDuLieu.Size = new System.Drawing.Size(148, 42);
            this.cLocDuLieu.TabIndex = 2;
            this.cLocDuLieu.Text = "Lọc dữ liệu";
            this.cLocDuLieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cLocDuLieu.UseVisualStyleBackColor = true;
            this.cLocDuLieu.Click += new System.EventHandler(this.cLocDuLieu_Click);
            // 
            // dtpLocDulieu
            // 
            this.dtpLocDulieu.CustomFormat = "MM/yyyy";
            this.dtpLocDulieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLocDulieu.Location = new System.Drawing.Point(157, 33);
            this.dtpLocDulieu.Name = "dtpLocDulieu";
            this.dtpLocDulieu.Size = new System.Drawing.Size(114, 20);
            this.dtpLocDulieu.TabIndex = 1;
            this.dtpLocDulieu.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng Năm :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataSalary
            // 
            this.dataSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaNhanVien,
            this.UserName,
            this.cLuongCoBan,
            this.cPhat,
            this.cThuong,
            this.cTongLuong,
            this.cLuongDaNhan,
            this.cLuongConThieu,
            this.cMonth,
            this.cNhanDu});
            this.dataSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSalary.Location = new System.Drawing.Point(0, 0);
            this.dataSalary.Name = "dataSalary";
            this.dataSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataSalary.Size = new System.Drawing.Size(907, 448);
            this.dataSalary.TabIndex = 3;
            this.dataSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSalary_CellClick);
            this.dataSalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSalary_CellContentClick_1);
            this.dataSalary.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSalary_CellEndEdit);
            this.dataSalary.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSalary_RowLeave);
            this.dataSalary.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataSalary_RowPrePaint);
            // 
            // cMaNhanVien
            // 
            this.cMaNhanVien.DataPropertyName = "IDEmployee";
            this.cMaNhanVien.HeaderText = "ID";
            this.cMaNhanVien.Name = "cMaNhanVien";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Họ và tên";
            this.UserName.Name = "UserName";
            // 
            // cLuongCoBan
            // 
            this.cLuongCoBan.DataPropertyName = "LuongCoBan";
            this.cLuongCoBan.HeaderText = "Lương cơ bản";
            this.cLuongCoBan.Name = "cLuongCoBan";
            // 
            // cPhat
            // 
            this.cPhat.DataPropertyName = "Phat";
            this.cPhat.HeaderText = "Phạt";
            this.cPhat.Name = "cPhat";
            // 
            // cThuong
            // 
            this.cThuong.DataPropertyName = "Thuong";
            this.cThuong.HeaderText = "Thưởng";
            this.cThuong.Name = "cThuong";
            // 
            // cTongLuong
            // 
            this.cTongLuong.DataPropertyName = "none";
            this.cTongLuong.HeaderText = "Tổng Lương";
            this.cTongLuong.Name = "cTongLuong";
            // 
            // cLuongDaNhan
            // 
            this.cLuongDaNhan.DataPropertyName = "LuongDaNhan";
            this.cLuongDaNhan.HeaderText = "Lương đã nhận";
            this.cLuongDaNhan.Name = "cLuongDaNhan";
            this.cLuongDaNhan.Width = 120;
            // 
            // cLuongConThieu
            // 
            this.cLuongConThieu.DataPropertyName = "none";
            this.cLuongConThieu.HeaderText = "Lương còn thiếu";
            this.cLuongConThieu.Name = "cLuongConThieu";
            this.cLuongConThieu.Width = 120;
            // 
            // cMonth
            // 
            this.cMonth.DataPropertyName = "Month";
            this.cMonth.HeaderText = "Tháng Năm";
            this.cMonth.Name = "cMonth";
            this.cMonth.Width = 120;
            // 
            // cNhanDu
            // 
            this.cNhanDu.HeaderText = "Nhận đủ ";
            this.cNhanDu.Name = "cNhanDu";
            this.cNhanDu.ReadOnly = true;
            this.cNhanDu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cNhanDu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmListSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 525);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListSalary";
            this.Text = "BangLuong";
            this.Load += new System.EventHandler(this.frmListSalary_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button cLocDuLieu;
        private System.Windows.Forms.DateTimePicker dtpLocDulieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatExcel;
        private Button Resest;
        private Button btnDelete;
        private DataGridView dataSalary;
        private DataGridViewTextBoxColumn cMaNhanVien;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn cLuongCoBan;
        private DataGridViewTextBoxColumn cPhat;
        private DataGridViewTextBoxColumn cThuong;
        private DataGridViewTextBoxColumn cTongLuong;
        private DataGridViewTextBoxColumn cLuongDaNhan;
        private DataGridViewTextBoxColumn cLuongConThieu;
        private DataGridViewTextBoxColumn cMonth;
        private DataGridViewCheckBoxColumn cNhanDu;
    }
}