namespace QuanLyThanhVien.Views
{
    partial class urcProject
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
            this.pgbComplete = new System.Windows.Forms.ProgressBar();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.lblComplete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbComplete
            // 
            this.pgbComplete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgbComplete.Location = new System.Drawing.Point(0, 140);
            this.pgbComplete.Name = "pgbComplete";
            this.pgbComplete.Size = new System.Drawing.Size(250, 10);
            this.pgbComplete.TabIndex = 7;
            this.pgbComplete.Value = 100;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(0, 78);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(250, 23);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = " End date : 25/6/2020";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(0, 55);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(250, 23);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start date : 5/6/2020";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameProject
            // 
            this.lblNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProject.Location = new System.Drawing.Point(0, 0);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(250, 41);
            this.lblNameProject.TabIndex = 4;
            this.lblNameProject.Text = "Lập trình trên window";
            this.lblNameProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameProject.Click += new System.EventHandler(this.showinfo);
            // 
            // lblComplete
            // 
            this.lblComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.Location = new System.Drawing.Point(0, 114);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(250, 23);
            this.lblComplete.TabIndex = 8;
            this.lblComplete.Text = "100%";
            this.lblComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // urcProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.pgbComplete);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblNameProject);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "urcProject";
            this.Size = new System.Drawing.Size(250, 150);
            this.Click += new System.EventHandler(this.showinfo);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbComplete;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.Label lblComplete;
    }
}
