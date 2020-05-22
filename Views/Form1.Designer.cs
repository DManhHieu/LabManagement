namespace LabManagement.Views
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlwindows = new System.Windows.Forms.Panel();
            this.pnlActivity = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblLabInfo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMail = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBudgetMenu = new System.Windows.Forms.Button();
            this.pnlFinanceMenu = new System.Windows.Forms.Panel();
            this.btnTimeMenu = new System.Windows.Forms.Button();
            this.pnlTimeMenu = new System.Windows.Forms.Panel();
            this.btnProjectsMenu = new System.Windows.Forms.Button();
            this.pnlProjectsMenu = new System.Windows.Forms.Panel();
            this.btnMyWorkMenu = new System.Windows.Forms.Button();
            this.pnlMyWorkMenu = new System.Windows.Forms.Panel();
            this.btnTeamMenu = new System.Windows.Forms.Button();
            this.pnlTeamMenu = new System.Windows.Forms.Panel();
            this.btnDashBoardMenu = new System.Windows.Forms.Button();
            this.pnlDashBoardMenu = new System.Windows.Forms.Panel();
            this.pnlwindows.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlwindows
            // 
            this.pnlwindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlwindows.Controls.Add(this.pnlActivity);
            this.pnlwindows.Controls.Add(this.panel1);
            this.pnlwindows.Controls.Add(this.pnlMenu);
            this.pnlwindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlwindows.Location = new System.Drawing.Point(0, 0);
            this.pnlwindows.Name = "pnlwindows";
            this.pnlwindows.Size = new System.Drawing.Size(1300, 680);
            this.pnlwindows.TabIndex = 1;
            // 
            // pnlActivity
            // 
            this.pnlActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActivity.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlActivity.Location = new System.Drawing.Point(141, 35);
            this.pnlActivity.Name = "pnlActivity";
            this.pnlActivity.Size = new System.Drawing.Size(1159, 645);
            this.pnlActivity.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.lblLabInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.panel1.Location = new System.Drawing.Point(141, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 35);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(986, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đoàn Mạnh Hiếu";
            // 
            // picClose
            // 
            this.picClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picClose.Image = global::LabManagement.Properties.Resources.baseline_exit_to_app_black_24dp;
            this.picClose.Location = new System.Drawing.Point(1132, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblLabInfo
            // 
            this.lblLabInfo.AutoSize = true;
            this.lblLabInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblLabInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLabInfo.Font = new System.Drawing.Font("Cambria", 12F);
            this.lblLabInfo.ForeColor = System.Drawing.Color.Black;
            this.lblLabInfo.Location = new System.Drawing.Point(469, 6);
            this.lblLabInfo.Name = "lblLabInfo";
            this.lblLabInfo.Size = new System.Drawing.Size(241, 19);
            this.lblLabInfo.TabIndex = 0;
            this.lblLabInfo.Text = "Lập trình trên windows, nhóm 10";
            this.lblLabInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoSize = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnMail);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.btnBudgetMenu);
            this.pnlMenu.Controls.Add(this.pnlFinanceMenu);
            this.pnlMenu.Controls.Add(this.btnTimeMenu);
            this.pnlMenu.Controls.Add(this.pnlTimeMenu);
            this.pnlMenu.Controls.Add(this.btnProjectsMenu);
            this.pnlMenu.Controls.Add(this.pnlProjectsMenu);
            this.pnlMenu.Controls.Add(this.btnMyWorkMenu);
            this.pnlMenu.Controls.Add(this.pnlMyWorkMenu);
            this.pnlMenu.Controls.Add(this.btnTeamMenu);
            this.pnlMenu.Controls.Add(this.pnlTeamMenu);
            this.pnlMenu.Controls.Add(this.btnDashBoardMenu);
            this.pnlMenu.Controls.Add(this.pnlDashBoardMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(141, 680);
            this.pnlMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LabManagement.Properties.Resources.ava;
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.btnMail.FlatAppearance.BorderSize = 0;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnMail.ForeColor = System.Drawing.Color.Black;
            this.btnMail.Image = global::LabManagement.Properties.Resources.mail;
            this.btnMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMail.Location = new System.Drawing.Point(9, 425);
            this.btnMail.Margin = new System.Windows.Forms.Padding(0);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(132, 50);
            this.btnMail.TabIndex = 5;
            this.btnMail.Text = "Mail";
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMail.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 50);
            this.panel2.TabIndex = 4;
            // 
            // btnBudgetMenu
            // 
            this.btnBudgetMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.btnBudgetMenu.FlatAppearance.BorderSize = 0;
            this.btnBudgetMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgetMenu.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnBudgetMenu.ForeColor = System.Drawing.Color.Black;
            this.btnBudgetMenu.Image = global::LabManagement.Properties.Resources.finace;
            this.btnBudgetMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBudgetMenu.Location = new System.Drawing.Point(9, 480);
            this.btnBudgetMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnBudgetMenu.Name = "btnBudgetMenu";
            this.btnBudgetMenu.Size = new System.Drawing.Size(132, 50);
            this.btnBudgetMenu.TabIndex = 5;
            this.btnBudgetMenu.Text = "Budget";
            this.btnBudgetMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBudgetMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBudgetMenu.UseVisualStyleBackColor = false;
            this.btnBudgetMenu.Click += new System.EventHandler(this.btnBudgetMenu_Click);
            // 
            // pnlFinanceMenu
            // 
            this.pnlFinanceMenu.Location = new System.Drawing.Point(0, 480);
            this.pnlFinanceMenu.Name = "pnlFinanceMenu";
            this.pnlFinanceMenu.Size = new System.Drawing.Size(10, 50);
            this.pnlFinanceMenu.TabIndex = 4;
            // 
            // btnTimeMenu
            // 
            this.btnTimeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.btnTimeMenu.FlatAppearance.BorderSize = 0;
            this.btnTimeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeMenu.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnTimeMenu.ForeColor = System.Drawing.Color.Black;
            this.btnTimeMenu.Image = global::LabManagement.Properties.Resources.time;
            this.btnTimeMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeMenu.Location = new System.Drawing.Point(9, 370);
            this.btnTimeMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimeMenu.Name = "btnTimeMenu";
            this.btnTimeMenu.Size = new System.Drawing.Size(132, 50);
            this.btnTimeMenu.TabIndex = 5;
            this.btnTimeMenu.Text = "Time";
            this.btnTimeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimeMenu.UseVisualStyleBackColor = false;
            this.btnTimeMenu.Click += new System.EventHandler(this.btnTimeMenu_Click);
            // 
            // pnlTimeMenu
            // 
            this.pnlTimeMenu.Location = new System.Drawing.Point(0, 370);
            this.pnlTimeMenu.Name = "pnlTimeMenu";
            this.pnlTimeMenu.Size = new System.Drawing.Size(10, 50);
            this.pnlTimeMenu.TabIndex = 4;
            // 
            // btnProjectsMenu
            // 
            this.btnProjectsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.btnProjectsMenu.FlatAppearance.BorderSize = 0;
            this.btnProjectsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectsMenu.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnProjectsMenu.ForeColor = System.Drawing.Color.Black;
            this.btnProjectsMenu.Image = global::LabManagement.Properties.Resources.project_management;
            this.btnProjectsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectsMenu.Location = new System.Drawing.Point(9, 315);
            this.btnProjectsMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnProjectsMenu.Name = "btnProjectsMenu";
            this.btnProjectsMenu.Size = new System.Drawing.Size(132, 50);
            this.btnProjectsMenu.TabIndex = 5;
            this.btnProjectsMenu.Text = " Projects";
            this.btnProjectsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectsMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjectsMenu.UseVisualStyleBackColor = false;
            this.btnProjectsMenu.Click += new System.EventHandler(this.btnProjectsMenu_Click);
            // 
            // pnlProjectsMenu
            // 
            this.pnlProjectsMenu.Location = new System.Drawing.Point(0, 315);
            this.pnlProjectsMenu.Name = "pnlProjectsMenu";
            this.pnlProjectsMenu.Size = new System.Drawing.Size(10, 50);
            this.pnlProjectsMenu.TabIndex = 4;
            // 
            // btnMyWorkMenu
            // 
            this.btnMyWorkMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.btnMyWorkMenu.FlatAppearance.BorderSize = 0;
            this.btnMyWorkMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyWorkMenu.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnMyWorkMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMyWorkMenu.Image = global::LabManagement.Properties.Resources.mywork;
            this.btnMyWorkMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyWorkMenu.Location = new System.Drawing.Point(9, 260);
            this.btnMyWorkMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMyWorkMenu.Name = "btnMyWorkMenu";
            this.btnMyWorkMenu.Size = new System.Drawing.Size(132, 50);
            this.btnMyWorkMenu.TabIndex = 5;
            this.btnMyWorkMenu.Text = " My Task";
            this.btnMyWorkMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyWorkMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyWorkMenu.UseVisualStyleBackColor = false;
            this.btnMyWorkMenu.Click += new System.EventHandler(this.btnMyWorkMenu_Click);
            // 
            // pnlMyWorkMenu
            // 
            this.pnlMyWorkMenu.Location = new System.Drawing.Point(0, 260);
            this.pnlMyWorkMenu.Name = "pnlMyWorkMenu";
            this.pnlMyWorkMenu.Size = new System.Drawing.Size(10, 50);
            this.pnlMyWorkMenu.TabIndex = 4;
            // 
            // btnTeamMenu
            // 
            this.btnTeamMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.btnTeamMenu.FlatAppearance.BorderSize = 0;
            this.btnTeamMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeamMenu.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnTeamMenu.ForeColor = System.Drawing.Color.Black;
            this.btnTeamMenu.Image = global::LabManagement.Properties.Resources.team;
            this.btnTeamMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamMenu.Location = new System.Drawing.Point(9, 205);
            this.btnTeamMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeamMenu.Name = "btnTeamMenu";
            this.btnTeamMenu.Size = new System.Drawing.Size(132, 50);
            this.btnTeamMenu.TabIndex = 3;
            this.btnTeamMenu.Text = "Team";
            this.btnTeamMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeamMenu.UseVisualStyleBackColor = false;
            this.btnTeamMenu.Click += new System.EventHandler(this.btnTeamMenu_Click);
            // 
            // pnlTeamMenu
            // 
            this.pnlTeamMenu.Location = new System.Drawing.Point(0, 205);
            this.pnlTeamMenu.Name = "pnlTeamMenu";
            this.pnlTeamMenu.Size = new System.Drawing.Size(10, 50);
            this.pnlTeamMenu.TabIndex = 2;
            // 
            // btnDashBoardMenu
            // 
            this.btnDashBoardMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.btnDashBoardMenu.FlatAppearance.BorderSize = 0;
            this.btnDashBoardMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoardMenu.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoardMenu.ForeColor = System.Drawing.Color.Black;
            this.btnDashBoardMenu.Image = global::LabManagement.Properties.Resources.dashboard;
            this.btnDashBoardMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoardMenu.Location = new System.Drawing.Point(9, 150);
            this.btnDashBoardMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashBoardMenu.Name = "btnDashBoardMenu";
            this.btnDashBoardMenu.Size = new System.Drawing.Size(132, 50);
            this.btnDashBoardMenu.TabIndex = 1;
            this.btnDashBoardMenu.Text = " DashBoard";
            this.btnDashBoardMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoardMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoardMenu.UseVisualStyleBackColor = false;
            this.btnDashBoardMenu.Click += new System.EventHandler(this.btnDashBoardMenu_Click);
            // 
            // pnlDashBoardMenu
            // 
            this.pnlDashBoardMenu.Location = new System.Drawing.Point(0, 150);
            this.pnlDashBoardMenu.Name = "pnlDashBoardMenu";
            this.pnlDashBoardMenu.Size = new System.Drawing.Size(10, 50);
            this.pnlDashBoardMenu.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1300, 680);
            this.Controls.Add(this.pnlwindows);
            this.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlwindows.ResumeLayout(false);
            this.pnlwindows.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlwindows;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBudgetMenu;
        private System.Windows.Forms.Panel pnlFinanceMenu;
        private System.Windows.Forms.Button btnTimeMenu;
        private System.Windows.Forms.Panel pnlTimeMenu;
        private System.Windows.Forms.Button btnProjectsMenu;
        private System.Windows.Forms.Panel pnlProjectsMenu;
        private System.Windows.Forms.Button btnMyWorkMenu;
        private System.Windows.Forms.Panel pnlMyWorkMenu;
        private System.Windows.Forms.Button btnTeamMenu;
        private System.Windows.Forms.Panel pnlTeamMenu;
        private System.Windows.Forms.Button btnDashBoardMenu;
        private System.Windows.Forms.Panel pnlDashBoardMenu;
        private System.Windows.Forms.Panel pnlActivity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblLabInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}