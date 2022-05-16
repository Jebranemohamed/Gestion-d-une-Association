
namespace Entreprise
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelexit = new System.Windows.Forms.Panel();
            this.btnLogOut = new RJCodeAdvance.RJControls.RJButton();
            this.panelfinance = new System.Windows.Forms.Panel();
            this.btnFinance = new RJCodeAdvance.RJControls.RJButton();
            this.panelusers = new System.Windows.Forms.Panel();
            this.btnUsers = new RJCodeAdvance.RJControls.RJButton();
            this.btnActivities = new RJCodeAdvance.RJControls.RJButton();
            this.panelmembers = new System.Windows.Forms.Panel();
            this.btnAdherent = new RJCodeAdvance.RJControls.RJButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            this.panelexit.SuspendLayout();
            this.panelfinance.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panelNav.Controls.Add(this.btnUsers);
            this.panelNav.Controls.Add(this.btnFinance);
            this.panelNav.Controls.Add(this.btnLogOut);
            this.panelNav.Controls.Add(this.panelexit);
            this.panelNav.Controls.Add(this.panelfinance);
            this.panelNav.Controls.Add(this.panelusers);
            this.panelNav.Controls.Add(this.panelmembers);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNav.Location = new System.Drawing.Point(765, 41);
            this.panelNav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(175, 498);
            this.panelNav.TabIndex = 2;
            // 
            // panelexit
            // 
            this.panelexit.Controls.Add(this.btnActivities);
            this.panelexit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelexit.Location = new System.Drawing.Point(0, 170);
            this.panelexit.MaximumSize = new System.Drawing.Size(175, 85);
            this.panelexit.MinimumSize = new System.Drawing.Size(175, 85);
            this.panelexit.Name = "panelexit";
            this.panelexit.Size = new System.Drawing.Size(175, 85);
            this.panelexit.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnLogOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnLogOut.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.BorderSize = 0;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(0, 413);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogOut.MaximumSize = new System.Drawing.Size(175, 75);
            this.btnLogOut.MinimumSize = new System.Drawing.Size(175, 75);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLogOut.Size = new System.Drawing.Size(175, 75);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "خروج";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOut.TextColor = System.Drawing.Color.White;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelfinance
            // 
            this.panelfinance.Controls.Add(this.btnAdherent);
            this.panelfinance.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelfinance.Location = new System.Drawing.Point(0, 85);
            this.panelfinance.MaximumSize = new System.Drawing.Size(175, 85);
            this.panelfinance.MinimumSize = new System.Drawing.Size(175, 85);
            this.panelfinance.Name = "panelfinance";
            this.panelfinance.Size = new System.Drawing.Size(175, 85);
            this.panelfinance.TabIndex = 4;
            // 
            // btnFinance
            // 
            this.btnFinance.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.btnFinance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnFinance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnFinance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnFinance.BorderRadius = 0;
            this.btnFinance.BorderSize = 0;
            this.btnFinance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinance.FlatAppearance.BorderSize = 0;
            this.btnFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.ForeColor = System.Drawing.Color.White;
            this.btnFinance.Image = ((System.Drawing.Image)(resources.GetObject("btnFinance.Image")));
            this.btnFinance.Location = new System.Drawing.Point(0, 327);
            this.btnFinance.Margin = new System.Windows.Forms.Padding(10);
            this.btnFinance.MaximumSize = new System.Drawing.Size(175, 75);
            this.btnFinance.MinimumSize = new System.Drawing.Size(175, 75);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(175, 75);
            this.btnFinance.TabIndex = 3;
            this.btnFinance.Text = "تمويل";
            this.btnFinance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinance.TextColor = System.Drawing.Color.White;
            this.btnFinance.UseVisualStyleBackColor = false;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // panelusers
            // 
            this.panelusers.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelusers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelusers.BackgroundImage")));
            this.panelusers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelusers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelusers.Location = new System.Drawing.Point(0, 0);
            this.panelusers.MaximumSize = new System.Drawing.Size(175, 85);
            this.panelusers.MinimumSize = new System.Drawing.Size(175, 85);
            this.panelusers.Name = "panelusers";
            this.panelusers.Size = new System.Drawing.Size(175, 85);
            this.panelusers.TabIndex = 3;
            // 
            // btnUsers
            // 
            this.btnUsers.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnUsers.BorderRadius = 0;
            this.btnUsers.BorderSize = 0;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.Location = new System.Drawing.Point(0, 241);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(10);
            this.btnUsers.MaximumSize = new System.Drawing.Size(175, 75);
            this.btnUsers.MinimumSize = new System.Drawing.Size(175, 75);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(175, 75);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "مستخدمون";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.TextColor = System.Drawing.Color.White;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnActivities
            // 
            this.btnActivities.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.btnActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnActivities.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnActivities.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnActivities.BorderRadius = 0;
            this.btnActivities.BorderSize = 0;
            this.btnActivities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivities.FlatAppearance.BorderSize = 0;
            this.btnActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivities.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.ForeColor = System.Drawing.Color.White;
            this.btnActivities.Image = ((System.Drawing.Image)(resources.GetObject("btnActivities.Image")));
            this.btnActivities.Location = new System.Drawing.Point(0, -14);
            this.btnActivities.Margin = new System.Windows.Forms.Padding(10);
            this.btnActivities.MaximumSize = new System.Drawing.Size(175, 75);
            this.btnActivities.MinimumSize = new System.Drawing.Size(175, 75);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(175, 75);
            this.btnActivities.TabIndex = 1;
            this.btnActivities.Text = "أنشطة";
            this.btnActivities.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivities.TextColor = System.Drawing.Color.White;
            this.btnActivities.UseVisualStyleBackColor = false;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // panelmembers
            // 
            this.panelmembers.Location = new System.Drawing.Point(0, 0);
            this.panelmembers.Name = "panelmembers";
            this.panelmembers.Size = new System.Drawing.Size(175, 103);
            this.panelmembers.TabIndex = 0;
            // 
            // btnAdherent
            // 
            this.btnAdherent.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.btnAdherent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdherent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAdherent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAdherent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAdherent.BorderRadius = 0;
            this.btnAdherent.BorderSize = 0;
            this.btnAdherent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdherent.FlatAppearance.BorderSize = 0;
            this.btnAdherent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdherent.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdherent.ForeColor = System.Drawing.Color.White;
            this.btnAdherent.Image = ((System.Drawing.Image)(resources.GetObject("btnAdherent.Image")));
            this.btnAdherent.Location = new System.Drawing.Point(0, -3);
            this.btnAdherent.Margin = new System.Windows.Forms.Padding(10);
            this.btnAdherent.MaximumSize = new System.Drawing.Size(175, 75);
            this.btnAdherent.MinimumSize = new System.Drawing.Size(175, 75);
            this.btnAdherent.Name = "btnAdherent";
            this.btnAdherent.Size = new System.Drawing.Size(175, 75);
            this.btnAdherent.TabIndex = 0;
            this.btnAdherent.Text = "أعضاء";
            this.btnAdherent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdherent.TextColor = System.Drawing.Color.White;
            this.btnAdherent.UseVisualStyleBackColor = false;
            this.btnAdherent.Click += new System.EventHandler(this.btnAdherent_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.AutoSize = true;
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panelContent.Controls.Add(this.labelControl1);
            this.panelContent.Controls.Add(this.pictureBox1);
            this.panelContent.Location = new System.Drawing.Point(0, 41);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(767, 498);
            this.panelContent.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(39, 213);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(638, 58);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "مرحبا بك في برنامج الجمعية";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-24, -795);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(940, 41);
            this.panelHeader.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(845, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(49, 41);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(894, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 41);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(940, 539);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برامج الجمعيات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelNav.ResumeLayout(false);
            this.panelexit.ResumeLayout(false);
            this.panelfinance.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelexit;
        private System.Windows.Forms.Panel panelfinance;
        private System.Windows.Forms.Panel panelusers;
        private System.Windows.Forms.Panel panelmembers;
        public RJCodeAdvance.RJControls.RJButton btnLogOut;
        public RJCodeAdvance.RJControls.RJButton btnFinance;
        public RJCodeAdvance.RJControls.RJButton btnUsers;
        public RJCodeAdvance.RJControls.RJButton btnActivities;
        public RJCodeAdvance.RJControls.RJButton btnAdherent;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
    }
}