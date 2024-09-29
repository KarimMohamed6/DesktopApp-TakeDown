namespace Take_Down
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStickyNotes = new System.Windows.Forms.Button();
            this.btnMyNotes = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.ibtnMenu = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnTweter = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxmize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rjDropdownMenu1 = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.ucHome1 = new Take_Down.ucHome();
            this.ucStickyNotes1 = new Take_Down.ucStickyNotes();
            this.ucSettings1 = new Take_Down.ucSettings();
            this.ucAboutUs1 = new Take_Down.ucAboutUs();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.panelMenu.Controls.Add(this.panelScroll);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnAboutUs);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnStickyNotes);
            this.panelMenu.Controls.Add(this.btnMyNotes);
            this.panelMenu.Controls.Add(this.btnCategories);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 677);
            this.panelMenu.TabIndex = 1;
            // 
            // panelScroll
            // 
            this.panelScroll.BackColor = System.Drawing.Color.White;
            this.panelScroll.Location = new System.Drawing.Point(3, 175);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(10, 57);
            this.panelScroll.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 616);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 61);
            this.btnExit.TabIndex = 11;
            this.btnExit.Tag = "Exit";
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.Image")));
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 454);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(250, 57);
            this.btnAboutUs.TabIndex = 10;
            this.btnAboutUs.Tag = "About Us";
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 397);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(250, 57);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Tag = "Settings";
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStickyNotes
            // 
            this.btnStickyNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStickyNotes.FlatAppearance.BorderSize = 0;
            this.btnStickyNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStickyNotes.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStickyNotes.Image = ((System.Drawing.Image)(resources.GetObject("btnStickyNotes.Image")));
            this.btnStickyNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStickyNotes.Location = new System.Drawing.Point(0, 340);
            this.btnStickyNotes.Name = "btnStickyNotes";
            this.btnStickyNotes.Size = new System.Drawing.Size(250, 57);
            this.btnStickyNotes.TabIndex = 8;
            this.btnStickyNotes.Tag = "Sticky Notes";
            this.btnStickyNotes.Text = "Sticky Notes";
            this.btnStickyNotes.UseVisualStyleBackColor = true;
            this.btnStickyNotes.Click += new System.EventHandler(this.btnStickyNotes_Click);
            // 
            // btnMyNotes
            // 
            this.btnMyNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyNotes.FlatAppearance.BorderSize = 0;
            this.btnMyNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyNotes.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyNotes.Image = ((System.Drawing.Image)(resources.GetObject("btnMyNotes.Image")));
            this.btnMyNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyNotes.Location = new System.Drawing.Point(0, 283);
            this.btnMyNotes.Name = "btnMyNotes";
            this.btnMyNotes.Size = new System.Drawing.Size(250, 57);
            this.btnMyNotes.TabIndex = 7;
            this.btnMyNotes.Tag = "My Notes";
            this.btnMyNotes.Text = "My Notes";
            this.btnMyNotes.UseVisualStyleBackColor = true;
            this.btnMyNotes.Click += new System.EventHandler(this.btnMyNotes_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Image")));
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(0, 226);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(250, 57);
            this.btnCategories.TabIndex = 6;
            this.btnCategories.Tag = "Categories";
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 169);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(250, 57);
            this.btnHome.TabIndex = 5;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Controls.Add(this.ibtnMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 169);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(159, 147);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // ibtnMenu
            // 
            this.ibtnMenu.FlatAppearance.BorderSize = 0;
            this.ibtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMenu.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.ibtnMenu.IconColor = System.Drawing.Color.White;
            this.ibtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMenu.Location = new System.Drawing.Point(170, 30);
            this.ibtnMenu.Name = "ibtnMenu";
            this.ibtnMenu.Size = new System.Drawing.Size(77, 108);
            this.ibtnMenu.TabIndex = 1;
            this.ibtnMenu.UseVisualStyleBackColor = true;
            this.ibtnMenu.Click += new System.EventHandler(this.ibtnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.btnFacebook);
            this.panel1.Controls.Add(this.btnTweter);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaxmize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 30);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnFacebook
            // 
            this.btnFacebook.FlatAppearance.BorderSize = 0;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Image = ((System.Drawing.Image)(resources.GetObject("btnFacebook.Image")));
            this.btnFacebook.Location = new System.Drawing.Point(36, 2);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(21, 28);
            this.btnFacebook.TabIndex = 11;
            this.btnFacebook.UseVisualStyleBackColor = true;
            // 
            // btnTweter
            // 
            this.btnTweter.FlatAppearance.BorderSize = 0;
            this.btnTweter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTweter.Image = ((System.Drawing.Image)(resources.GetObject("btnTweter.Image")));
            this.btnTweter.Location = new System.Drawing.Point(9, 1);
            this.btnTweter.Name = "btnTweter";
            this.btnTweter.Size = new System.Drawing.Size(21, 28);
            this.btnTweter.TabIndex = 10;
            this.btnTweter.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(805, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 28);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxmize
            // 
            this.btnMaxmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxmize.FlatAppearance.BorderSize = 0;
            this.btnMaxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxmize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxmize.Image")));
            this.btnMaxmize.Location = new System.Drawing.Point(832, -1);
            this.btnMaxmize.Name = "btnMaxmize";
            this.btnMaxmize.Size = new System.Drawing.Size(21, 28);
            this.btnMaxmize.TabIndex = 6;
            this.btnMaxmize.UseVisualStyleBackColor = true;
            this.btnMaxmize.Click += new System.EventHandler(this.btnMaxmize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(858, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.addNewToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(141, 52);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.White;
            this.panelCenter.Controls.Add(this.ucHome1);
            this.panelCenter.Controls.Add(this.ucStickyNotes1);
            this.panelCenter.Controls.Add(this.ucSettings1);
            this.panelCenter.Controls.Add(this.ucAboutUs1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(250, 30);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(882, 647);
            this.panelCenter.TabIndex = 3;
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(882, 647);
            this.ucHome1.TabIndex = 6;
            // 
            // ucStickyNotes1
            // 
            this.ucStickyNotes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.ucStickyNotes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStickyNotes1.Location = new System.Drawing.Point(0, 0);
            this.ucStickyNotes1.Name = "ucStickyNotes1";
            this.ucStickyNotes1.Padding = new System.Windows.Forms.Padding(2);
            this.ucStickyNotes1.Size = new System.Drawing.Size(882, 647);
            this.ucStickyNotes1.TabIndex = 2;
            // 
            // ucSettings1
            // 
            this.ucSettings1.BackColor = System.Drawing.Color.White;
            this.ucSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSettings1.Location = new System.Drawing.Point(0, 0);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Padding = new System.Windows.Forms.Padding(2);
            this.ucSettings1.Size = new System.Drawing.Size(882, 647);
            this.ucSettings1.TabIndex = 1;
            // 
            // ucAboutUs1
            // 
            this.ucAboutUs1.BackColor = System.Drawing.Color.White;
            this.ucAboutUs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAboutUs1.Location = new System.Drawing.Point(0, 0);
            this.ucAboutUs1.Name = "ucAboutUs1";
            this.ucAboutUs1.Padding = new System.Windows.Forms.Padding(2);
            this.ucAboutUs1.Size = new System.Drawing.Size(882, 647);
            this.ucAboutUs1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 677);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.rjDropdownMenu1.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelScroll;
        private Button btnExit;
        private Button btnAboutUs;
        private Button btnSettings;
        private Button btnStickyNotes;
        private Button btnMyNotes;
        private Button btnCategories;
        private Button btnHome;
        private Panel panelLogo;
        private PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton ibtnMenu;
        private Panel panel1;
        private Button btnMinimize;
        private Button btnMaxmize;
        private Button btnClose;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu1;
        private ToolStripMenuItem showAllToolStripMenuItem;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private Panel panelCenter;
        private Button btnFacebook;
        private Button btnTweter;
        private ucCategories ucCategories1;
        private ucShowNotes ucShowNotes1;
        private ucAddNote ucAddNote1;
        private ucStickyNotes ucStickyNotes1;
        private ucSettings ucSettings1;
        private ucAboutUs ucAboutUs1;
        private ucHome ucHome1;
    }
}