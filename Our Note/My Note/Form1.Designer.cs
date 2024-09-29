namespace My_Note
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
            this.btnNewNote = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.ibtnMenu = new FontAwesome.Sharp.IconButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxmize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.ucHome1 = new My_Note.ucHome();
            this.ucShowCategories1 = new My_Note.ucShowCategories();
            this.ucStickyNote1 = new My_Note.ucStickyNote();
            this.ucAddNote1 = new My_Note.ucAddNote();
            this.ucShowAllNotes1 = new My_Note.ucShowAllCategories();
            this.rjDropdownMenu1 = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.addNewTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletNote = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropdownMenu2 = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.showAllCategoryTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            this.rjDropdownMenu2.SuspendLayout();
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
            this.panelMenu.Controls.Add(this.btnNewNote);
            this.panelMenu.Controls.Add(this.btnCategories);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 724);
            this.panelMenu.TabIndex = 0;
            // 
            // panelScroll
            // 
            this.panelScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
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
            this.btnExit.Location = new System.Drawing.Point(0, 663);
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
            // btnNewNote
            // 
            this.btnNewNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewNote.FlatAppearance.BorderSize = 0;
            this.btnNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewNote.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewNote.Image = ((System.Drawing.Image)(resources.GetObject("btnNewNote.Image")));
            this.btnNewNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewNote.Location = new System.Drawing.Point(0, 283);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(250, 57);
            this.btnNewNote.TabIndex = 7;
            this.btnNewNote.Tag = "My Notes";
            this.btnNewNote.Text = "My Notes";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
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
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnMaxmize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(881, 30);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(803, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 28);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxmize
            // 
            this.btnMaxmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxmize.FlatAppearance.BorderSize = 0;
            this.btnMaxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxmize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxmize.Image")));
            this.btnMaxmize.Location = new System.Drawing.Point(830, -1);
            this.btnMaxmize.Name = "btnMaxmize";
            this.btnMaxmize.Size = new System.Drawing.Size(21, 28);
            this.btnMaxmize.TabIndex = 3;
            this.btnMaxmize.UseVisualStyleBackColor = true;
            this.btnMaxmize.Click += new System.EventHandler(this.btnMaxmize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(856, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.White;
            this.panelCenter.Controls.Add(this.ucHome1);
            this.panelCenter.Controls.Add(this.ucShowCategories1);
            this.panelCenter.Controls.Add(this.ucStickyNote1);
            this.panelCenter.Controls.Add(this.ucAddNote1);
            this.panelCenter.Controls.Add(this.ucShowAllNotes1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(250, 30);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(881, 694);
            this.panelCenter.TabIndex = 2;
            // 
            // ucHome1
            // 
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(881, 694);
            this.ucHome1.TabIndex = 1;
            // 
            // ucShowCategories1
            // 
            this.ucShowCategories1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucShowCategories1.Location = new System.Drawing.Point(0, 0);
            this.ucShowCategories1.Name = "ucShowCategories1";
            this.ucShowCategories1.Padding = new System.Windows.Forms.Padding(18);
            this.ucShowCategories1.Size = new System.Drawing.Size(881, 694);
            this.ucShowCategories1.TabIndex = 4;
            // 
            // ucStickyNote1
            // 
            this.ucStickyNote1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStickyNote1.Location = new System.Drawing.Point(0, 0);
            this.ucStickyNote1.Name = "ucStickyNote1";
            this.ucStickyNote1.Size = new System.Drawing.Size(881, 694);
            this.ucStickyNote1.TabIndex = 0;
            // 
            // ucAddNote1
            // 
            this.ucAddNote1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddNote1.Location = new System.Drawing.Point(0, 0);
            this.ucAddNote1.Name = "ucAddNote1";
            this.ucAddNote1.Size = new System.Drawing.Size(881, 694);
            this.ucAddNote1.TabIndex = 2;
            // 
            // ucShowAllNotes1
            // 
            this.ucShowAllNotes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ucShowAllNotes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucShowAllNotes1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucShowAllNotes1.Location = new System.Drawing.Point(0, 0);
            this.ucShowAllNotes1.Margin = new System.Windows.Forms.Padding(4);
            this.ucShowAllNotes1.Name = "ucShowAllNotes1";
            this.ucShowAllNotes1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.ucShowAllNotes1.Size = new System.Drawing.Size(881, 694);
            this.ucShowAllNotes1.TabIndex = 3;
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTSMItem,
            this.deletNote,
            this.showAllTSMItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.rjDropdownMenu1.Size = new System.Drawing.Size(152, 76);
            // 
            // addNewTSMItem
            // 
            this.addNewTSMItem.Name = "addNewTSMItem";
            this.addNewTSMItem.Size = new System.Drawing.Size(151, 24);
            this.addNewTSMItem.Text = "Add New";
            this.addNewTSMItem.Click += new System.EventHandler(this.addNewTSMItem_Click);
            // 
            // deletNote
            // 
            this.deletNote.Name = "deletNote";
            this.deletNote.Size = new System.Drawing.Size(151, 24);
            this.deletNote.Text = "Delet Note";
            // 
            // showAllTSMItem
            // 
            this.showAllTSMItem.Name = "showAllTSMItem";
            this.showAllTSMItem.Size = new System.Drawing.Size(151, 24);
            this.showAllTSMItem.Text = "Show All";
            this.showAllTSMItem.Click += new System.EventHandler(this.showAllTSMItem_Click);
            // 
            // rjDropdownMenu2
            // 
            this.rjDropdownMenu2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu2.IsMainMenu = false;
            this.rjDropdownMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllCategoryTSMItem});
            this.rjDropdownMenu2.MenuItemHeight = 25;
            this.rjDropdownMenu2.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu2.Name = "rjDropdownMenu2";
            this.rjDropdownMenu2.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu2.Size = new System.Drawing.Size(137, 28);
            // 
            // showAllCategoryTSMItem
            // 
            this.showAllCategoryTSMItem.Name = "showAllCategoryTSMItem";
            this.showAllCategoryTSMItem.Size = new System.Drawing.Size(136, 24);
            this.showAllCategoryTSMItem.Text = "Show All";
            this.showAllCategoryTSMItem.Click += new System.EventHandler(this.showAllCategoryTSMItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 724);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.rjDropdownMenu1.ResumeLayout(false);
            this.rjDropdownMenu2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelHeader;
        private Button btnClose;
        private Button btnMaxmize;
        private Button btnMinimize;
        private Panel panelCenter;
        private Panel panelLogo;
        private PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton ibtnMenu;
        private Button btnExit;
        private Button btnAboutUs;
        private Button btnSettings;
        private Button btnStickyNotes;
        private Button btnNewNote;
        private Button btnCategories;
        private Button btnHome;
        private Panel panelScroll;
        private ucHome ucHome1;
        private ucStickyNote ucStickyNote1;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu1;
        private ToolStripMenuItem addNewTSMItem;
        private ToolStripMenuItem deletNote;
        private ToolStripMenuItem showAllTSMItem;
        private ucAddNote ucAddNote1;
        private ucShowAllCategories ucShowAllNotes1;
        private ucShowCategories ucShowCategories1;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu2;
        private ToolStripMenuItem showAllCategoryTSMItem;
    }
}