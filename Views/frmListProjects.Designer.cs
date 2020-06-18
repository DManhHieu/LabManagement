namespace QuanLyThanhVien.Views
{
    partial class frmListProjects
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label144 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.flpListProjectToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.flpListProjectDoing = new System.Windows.Forms.FlowLayoutPanel();
            this.flpListProjectComplete = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label144);
            this.panel1.Controls.Add(this.label143);
            this.panel1.Controls.Add(this.label142);
            this.panel1.Controls.Add(this.btnNewProject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 72);
            this.panel1.TabIndex = 0;
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label144.Location = new System.Drawing.Point(585, 49);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(93, 20);
            this.label144.TabIndex = 3;
            this.label144.Text = "Hoàn thành";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label143.Location = new System.Drawing.Point(300, 49);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(77, 20);
            this.label143.TabIndex = 3;
            this.label143.Text = "Đang làm";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label142.Location = new System.Drawing.Point(12, 49);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(71, 20);
            this.label142.TabIndex = 2;
            this.label142.Text = "Cần làm ";
            // 
            // btnNewProject
            // 
            this.btnNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.Location = new System.Drawing.Point(743, 12);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(121, 40);
            this.btnNewProject.TabIndex = 1;
            this.btnNewProject.Text = "Dự án mới";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // flpListProjectToDo
            // 
            this.flpListProjectToDo.AutoScroll = true;
            this.flpListProjectToDo.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpListProjectToDo.Location = new System.Drawing.Point(0, 72);
            this.flpListProjectToDo.Name = "flpListProjectToDo";
            this.flpListProjectToDo.Size = new System.Drawing.Size(288, 473);
            this.flpListProjectToDo.TabIndex = 1;
            // 
            // flpListProjectDoing
            // 
            this.flpListProjectDoing.AutoScroll = true;
            this.flpListProjectDoing.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpListProjectDoing.Location = new System.Drawing.Point(288, 72);
            this.flpListProjectDoing.Name = "flpListProjectDoing";
            this.flpListProjectDoing.Size = new System.Drawing.Size(288, 473);
            this.flpListProjectDoing.TabIndex = 2;
            // 
            // flpListProjectComplete
            // 
            this.flpListProjectComplete.AutoScroll = true;
            this.flpListProjectComplete.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpListProjectComplete.Location = new System.Drawing.Point(576, 72);
            this.flpListProjectComplete.Name = "flpListProjectComplete";
            this.flpListProjectComplete.Size = new System.Drawing.Size(288, 473);
            this.flpListProjectComplete.TabIndex = 3;
            // 
            // frmListProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 545);
            this.Controls.Add(this.flpListProjectComplete);
            this.Controls.Add(this.flpListProjectDoing);
            this.Controls.Add(this.flpListProjectToDo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListProjects";
            this.Text = "frmListProjects";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.FlowLayoutPanel flpListProjectToDo;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.FlowLayoutPanel flpListProjectDoing;
        private System.Windows.Forms.FlowLayoutPanel flpListProjectComplete;
    }
}