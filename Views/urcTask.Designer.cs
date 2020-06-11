namespace QuanLyThanhVien.Views
{
    partial class urcTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbComplete = new System.Windows.Forms.CheckBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbComplete
            // 
            this.cbComplete.AutoSize = true;
            this.cbComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbComplete.Location = new System.Drawing.Point(3, 11);
            this.cbComplete.Name = "cbComplete";
            this.cbComplete.Size = new System.Drawing.Size(12, 11);
            this.cbComplete.TabIndex = 11;
            this.cbComplete.UseVisualStyleBackColor = true;
            this.cbComplete.CheckedChanged += new System.EventHandler(this.cbComplete_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(475, 39);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(53, 13);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "2/6/2020";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(279, 39);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(53, 13);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "2/6/2020";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "End date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start date";
            // 
            // lblProjectName
            // 
            this.lblProjectName.Location = new System.Drawing.Point(21, 32);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(143, 20);
            this.lblProjectName.TabIndex = 5;
            this.lblProjectName.Text = "Project name";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaskName
            // 
            this.lblTaskName.Location = new System.Drawing.Point(21, 6);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(467, 20);
            this.lblTaskName.TabIndex = 6;
            this.lblTaskName.Text = "Task name";
            this.lblTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskName.Click += new System.EventHandler(this.InfoTask);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(614, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(24, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // urcTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbComplete);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblTaskName);
            this.Name = "urcTask";
            this.Size = new System.Drawing.Size(865, 60);
            this.Click += new System.EventHandler(this.InfoTask);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbComplete;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Button btnDelete;
    }
}
