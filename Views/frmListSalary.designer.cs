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
            this.dataSalary = new System.Windows.Forms.DataGridView();
            this.cMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuongDaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLuongConThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhanDu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSalary
            // 
            this.dataSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaNhanVien,
            this.cHoTen,
            this.cLuongCoBan,
            this.cPhuCap,
            this.cPhat,
            this.cThuong,
            this.cTongLuong,
            this.cLuongDaNhan,
            this.cLuongConThieu,
            this.cNhanDu});
            this.dataSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSalary.Location = new System.Drawing.Point(0, 0);
            this.dataSalary.Name = "dataSalary";
            this.dataSalary.Size = new System.Drawing.Size(907, 525);
            this.dataSalary.TabIndex = 2;
            this.dataSalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLuong_CellContentClick);
            // 
            // cMaNhanVien
            // 
            this.cMaNhanVien.HeaderText = "Mã nhân viên";
            this.cMaNhanVien.Name = "cMaNhanVien";
            this.cMaNhanVien.ReadOnly = true;
            // 
            // cHoTen
            // 
            this.cHoTen.HeaderText = "Họ tên";
            this.cHoTen.Name = "cHoTen";
            this.cHoTen.ReadOnly = true;
            // 
            // cLuongCoBan
            // 
            this.cLuongCoBan.HeaderText = "Lương cơ bản";
            this.cLuongCoBan.Name = "cLuongCoBan";
            // 
            // cPhuCap
            // 
            this.cPhuCap.HeaderText = "Phụ cấp";
            this.cPhuCap.Name = "cPhuCap";
            // 
            // cPhat
            // 
            this.cPhat.HeaderText = "Phạt";
            this.cPhat.Name = "cPhat";
            // 
            // cThuong
            // 
            this.cThuong.HeaderText = "Thưởng";
            this.cThuong.Name = "cThuong";
            // 
            // cTongLuong
            // 
            this.cTongLuong.HeaderText = "Tổng Lương";
            this.cTongLuong.Name = "cTongLuong";
            this.cTongLuong.ReadOnly = true;
            // 
            // cLuongDaNhan
            // 
            this.cLuongDaNhan.HeaderText = "Lương đã nhận";
            this.cLuongDaNhan.Name = "cLuongDaNhan";
            this.cLuongDaNhan.Width = 120;
            // 
            // cLuongConThieu
            // 
            this.cLuongConThieu.HeaderText = "Lương còn thiếu";
            this.cLuongConThieu.Name = "cLuongConThieu";
            this.cLuongConThieu.Width = 120;
            // 
            // cNhanDu
            // 
            this.cNhanDu.HeaderText = "Nhận đủ ";
            this.cNhanDu.Name = "cNhanDu";
            this.cNhanDu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cNhanDu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmListSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 525);
            this.Controls.Add(this.dataSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListSalary";
            this.Text = "BangLuong";
            ((System.ComponentModel.ISupportInitialize)(this.dataSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLuongDaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLuongConThieu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cNhanDu;
    }
}