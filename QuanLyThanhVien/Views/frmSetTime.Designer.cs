namespace QuanLyThanhVien.Views
{
    partial class frmSetTime
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
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.flpListTimeWork = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpEndTimeNew = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTimeNew = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(15, 12);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(200, 20);
            this.dtpDay.TabIndex = 0;
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.Location = new System.Drawing.Point(12, 46);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(76, 13);
            this.lblNameEmployee.TabIndex = 4;
            this.lblNameEmployee.Text = "Tên nhân viên";
            // 
            // flpListTimeWork
            // 
            this.flpListTimeWork.AutoScroll = true;
            this.flpListTimeWork.Location = new System.Drawing.Point(15, 75);
            this.flpListTimeWork.Name = "flpListTimeWork";
            this.flpListTimeWork.Size = new System.Drawing.Size(267, 188);
            this.flpListTimeWork.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Controls.Add(this.dtpEndTimeNew);
            this.panel7.Controls.Add(this.dtpStartTimeNew);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Location = new System.Drawing.Point(15, 278);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 27);
            this.panel7.TabIndex = 6;
            // 
            // dtpEndTimeNew
            // 
            this.dtpEndTimeNew.CustomFormat = "hh/mm/ss";
            this.dtpEndTimeNew.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTimeNew.Location = new System.Drawing.Point(123, 3);
            this.dtpEndTimeNew.Name = "dtpEndTimeNew";
            this.dtpEndTimeNew.ShowUpDown = true;
            this.dtpEndTimeNew.Size = new System.Drawing.Size(74, 20);
            this.dtpEndTimeNew.TabIndex = 5;
            // 
            // dtpStartTimeNew
            // 
            this.dtpStartTimeNew.CustomFormat = "hh:mm";
            this.dtpStartTimeNew.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTimeNew.Location = new System.Drawing.Point(3, 3);
            this.dtpStartTimeNew.Name = "dtpStartTimeNew";
            this.dtpStartTimeNew.ShowUpDown = true;
            this.dtpStartTimeNew.Size = new System.Drawing.Size(82, 20);
            this.dtpStartTimeNew.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(91, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "To :";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(269, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(214, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 27);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmSetTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 317);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.flpListTimeWork);
            this.Controls.Add(this.lblNameEmployee);
            this.Controls.Add(this.dtpDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetTime";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.FlowLayoutPanel flpListTimeWork;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtpEndTimeNew;
        private System.Windows.Forms.DateTimePicker dtpStartTimeNew;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
    }
}