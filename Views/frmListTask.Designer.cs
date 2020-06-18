namespace QuanLyThanhVien.Views
{
    partial class frmListTask
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.dtpEndDateNewTask = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDateNewTask = new System.Windows.Forms.DateTimePicker();
            this.txtNameNewTask = new System.Windows.Forms.TextBox();
            this.cbNewTask = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.flpComplete = new System.Windows.Forms.FlowLayoutPanel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.flpDoing = new System.Windows.Forms.FlowLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flpExpired = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.lblPosition);
            this.panel2.Controls.Add(this.lblNameEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(314, 8);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Chức vụ";
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.Location = new System.Drawing.Point(149, 8);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(54, 13);
            this.lblNameEmployee.TabIndex = 0;
            this.lblNameEmployee.Text = "Họ và tên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbProject);
            this.panel1.Controls.Add(this.label53);
            this.panel1.Controls.Add(this.label52);
            this.panel1.Controls.Add(this.dtpEndDateNewTask);
            this.panel1.Controls.Add(this.dtpStartDateNewTask);
            this.panel1.Controls.Add(this.txtNameNewTask);
            this.panel1.Controls.Add(this.cbNewTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 50);
            this.panel1.TabIndex = 4;
            // 
            // cbProject
            // 
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(379, 14);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(188, 21);
            this.cbProject.TabIndex = 4;
            this.cbProject.Text = "Dự án";
            this.cbProject.Visible = false;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(614, 28);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(56, 13);
            this.label53.TabIndex = 3;
            this.label53.Text = "Kết thúc : ";
            this.label53.Visible = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(616, 3);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(54, 13);
            this.label52.TabIndex = 3;
            this.label52.Text = "Bắt đầu : ";
            this.label52.Visible = false;
            // 
            // dtpEndDateNewTask
            // 
            this.dtpEndDateNewTask.CustomFormat = "dd/MM/yyyy   hh/mm/ss";
            this.dtpEndDateNewTask.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDateNewTask.Location = new System.Drawing.Point(684, 22);
            this.dtpEndDateNewTask.Name = "dtpEndDateNewTask";
            this.dtpEndDateNewTask.Size = new System.Drawing.Size(197, 20);
            this.dtpEndDateNewTask.TabIndex = 2;
            this.dtpEndDateNewTask.Visible = false;
            // 
            // dtpStartDateNewTask
            // 
            this.dtpStartDateNewTask.CustomFormat = "dd/MM/yyyy   hh/mm/ss";
            this.dtpStartDateNewTask.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDateNewTask.Location = new System.Drawing.Point(684, 0);
            this.dtpStartDateNewTask.Name = "dtpStartDateNewTask";
            this.dtpStartDateNewTask.Size = new System.Drawing.Size(197, 20);
            this.dtpStartDateNewTask.TabIndex = 2;
            this.dtpStartDateNewTask.Visible = false;
            // 
            // txtNameNewTask
            // 
            this.txtNameNewTask.Location = new System.Drawing.Point(32, 15);
            this.txtNameNewTask.Name = "txtNameNewTask";
            this.txtNameNewTask.Size = new System.Drawing.Size(317, 20);
            this.txtNameNewTask.TabIndex = 1;
            this.txtNameNewTask.Text = "Thêm công việc mới";
            this.txtNameNewTask.Enter += new System.EventHandler(this.txtNameNewTask_Enter);
            this.txtNameNewTask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameNewTask_KeyPress);
            // 
            // cbNewTask
            // 
            this.cbNewTask.AutoSize = true;
            this.cbNewTask.Location = new System.Drawing.Point(11, 18);
            this.cbNewTask.Name = "cbNewTask";
            this.cbNewTask.Size = new System.Drawing.Size(15, 14);
            this.cbNewTask.TabIndex = 0;
            this.cbNewTask.UseVisualStyleBackColor = true;
            this.cbNewTask.Visible = false;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel15);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(905, 441);
            this.panel4.TabIndex = 5;
            // 
            // panel15
            // 
            this.panel15.AutoSize = true;
            this.panel15.Controls.Add(this.flpComplete);
            this.panel15.Controls.Add(this.panel19);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 64);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(905, 32);
            this.panel15.TabIndex = 2;
            // 
            // flpComplete
            // 
            this.flpComplete.AutoSize = true;
            this.flpComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpComplete.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpComplete.Location = new System.Drawing.Point(0, 32);
            this.flpComplete.Name = "flpComplete";
            this.flpComplete.Size = new System.Drawing.Size(905, 0);
            this.flpComplete.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label50);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(905, 32);
            this.panel19.TabIndex = 0;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 12);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(67, 13);
            this.label50.TabIndex = 0;
            this.label50.Text = "Hoàn Thành";
            this.label50.Click += new System.EventHandler(this.label50_Click);
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.Controls.Add(this.flpDoing);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 32);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(905, 32);
            this.panel10.TabIndex = 1;
            // 
            // flpDoing
            // 
            this.flpDoing.AutoSize = true;
            this.flpDoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDoing.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDoing.Location = new System.Drawing.Point(0, 32);
            this.flpDoing.Name = "flpDoing";
            this.flpDoing.Size = new System.Drawing.Size(905, 0);
            this.flpDoing.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label34);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(905, 32);
            this.panel14.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 12);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(52, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "Đang làm";
            this.label34.Click += new System.EventHandler(this.label34_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.flpExpired);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(905, 32);
            this.panel5.TabIndex = 0;
            // 
            // flpExpired
            // 
            this.flpExpired.AutoSize = true;
            this.flpExpired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpExpired.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpExpired.Location = new System.Drawing.Point(0, 32);
            this.flpExpired.Name = "flpExpired";
            this.flpExpired.Size = new System.Drawing.Size(905, 0);
            this.flpExpired.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(905, 32);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quá hạn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmListTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 525);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListTask";
            this.Text = "Danh sách công việc";
            this.Load += new System.EventHandler(this.frmTask_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flpExpired;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.FlowLayoutPanel flpComplete;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.FlowLayoutPanel flpDoing;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.DateTimePicker dtpEndDateNewTask;
        private System.Windows.Forms.DateTimePicker dtpStartDateNewTask;
        private System.Windows.Forms.TextBox txtNameNewTask;
        private System.Windows.Forms.CheckBox cbNewTask;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbProject;
    }
}