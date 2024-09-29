namespace My_Note
{
    partial class ucStickyNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStickyNote));
            this.panelStickyNote = new System.Windows.Forms.Panel();
            this.btnPlusNote = new System.Windows.Forms.Button();
            this.panelNote2 = new System.Windows.Forms.Panel();
            this.btnTrash2 = new System.Windows.Forms.Button();
            this.tbNote2 = new System.Windows.Forms.TextBox();
            this.panelHeaderNote2 = new System.Windows.Forms.Panel();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.panelNote1 = new System.Windows.Forms.Panel();
            this.btnTrash1 = new System.Windows.Forms.Button();
            this.tbNote1 = new System.Windows.Forms.TextBox();
            this.panelHeaderNote1 = new System.Windows.Forms.Panel();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.panelStickyNote.SuspendLayout();
            this.panelNote2.SuspendLayout();
            this.panelHeaderNote2.SuspendLayout();
            this.panelNote1.SuspendLayout();
            this.panelHeaderNote1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStickyNote
            // 
            this.panelStickyNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panelStickyNote.Controls.Add(this.btnPlusNote);
            this.panelStickyNote.Controls.Add(this.panelNote2);
            this.panelStickyNote.Controls.Add(this.panelNote1);
            this.panelStickyNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStickyNote.Location = new System.Drawing.Point(0, 0);
            this.panelStickyNote.Name = "panelStickyNote";
            this.panelStickyNote.Size = new System.Drawing.Size(860, 633);
            this.panelStickyNote.TabIndex = 0;
            // 
            // btnPlusNote
            // 
            this.btnPlusNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlusNote.FlatAppearance.BorderSize = 0;
            this.btnPlusNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusNote.Image = ((System.Drawing.Image)(resources.GetObject("btnPlusNote.Image")));
            this.btnPlusNote.Location = new System.Drawing.Point(365, 504);
            this.btnPlusNote.Name = "btnPlusNote";
            this.btnPlusNote.Size = new System.Drawing.Size(67, 72);
            this.btnPlusNote.TabIndex = 5;
            this.btnPlusNote.UseVisualStyleBackColor = true;
            // 
            // panelNote2
            // 
            this.panelNote2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNote2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(204)))), ((int)(((byte)(213)))));
            this.panelNote2.Controls.Add(this.btnTrash2);
            this.panelNote2.Controls.Add(this.tbNote2);
            this.panelNote2.Controls.Add(this.panelHeaderNote2);
            this.panelNote2.Location = new System.Drawing.Point(493, 66);
            this.panelNote2.Name = "panelNote2";
            this.panelNote2.Size = new System.Drawing.Size(272, 331);
            this.panelNote2.TabIndex = 5;
            // 
            // btnTrash2
            // 
            this.btnTrash2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrash2.FlatAppearance.BorderSize = 0;
            this.btnTrash2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash2.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash2.Image")));
            this.btnTrash2.Location = new System.Drawing.Point(3, 300);
            this.btnTrash2.Name = "btnTrash2";
            this.btnTrash2.Size = new System.Drawing.Size(19, 28);
            this.btnTrash2.TabIndex = 4;
            this.btnTrash2.UseVisualStyleBackColor = true;
            this.btnTrash2.Click += new System.EventHandler(this.btnTrash2_Click);
            // 
            // tbNote2
            // 
            this.tbNote2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNote2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNote2.Location = new System.Drawing.Point(24, 47);
            this.tbNote2.Multiline = true;
            this.tbNote2.Name = "tbNote2";
            this.tbNote2.Size = new System.Drawing.Size(216, 223);
            this.tbNote2.TabIndex = 1;
            this.tbNote2.Text = "  Start Writing...";
            this.tbNote2.Enter += new System.EventHandler(this.tbNote2_Enter);
            this.tbNote2.Leave += new System.EventHandler(this.tbNote2_Leave);
            // 
            // panelHeaderNote2
            // 
            this.panelHeaderNote2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(181)))), ((int)(((byte)(198)))));
            this.panelHeaderNote2.Controls.Add(this.btnClose2);
            this.panelHeaderNote2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderNote2.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderNote2.Name = "panelHeaderNote2";
            this.panelHeaderNote2.Size = new System.Drawing.Size(272, 32);
            this.panelHeaderNote2.TabIndex = 0;
            // 
            // btnClose2
            // 
            this.btnClose2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose2.FlatAppearance.BorderSize = 0;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Image = ((System.Drawing.Image)(resources.GetObject("btnClose2.Image")));
            this.btnClose2.Location = new System.Drawing.Point(250, 4);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(19, 28);
            this.btnClose2.TabIndex = 4;
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // panelNote1
            // 
            this.panelNote1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panelNote1.Controls.Add(this.btnTrash1);
            this.panelNote1.Controls.Add(this.tbNote1);
            this.panelNote1.Controls.Add(this.panelHeaderNote1);
            this.panelNote1.Location = new System.Drawing.Point(75, 63);
            this.panelNote1.Name = "panelNote1";
            this.panelNote1.Size = new System.Drawing.Size(272, 331);
            this.panelNote1.TabIndex = 0;
            // 
            // btnTrash1
            // 
            this.btnTrash1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrash1.FlatAppearance.BorderSize = 0;
            this.btnTrash1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash1.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash1.Image")));
            this.btnTrash1.Location = new System.Drawing.Point(3, 300);
            this.btnTrash1.Name = "btnTrash1";
            this.btnTrash1.Size = new System.Drawing.Size(19, 28);
            this.btnTrash1.TabIndex = 4;
            this.btnTrash1.UseVisualStyleBackColor = true;
            this.btnTrash1.Click += new System.EventHandler(this.btnTrash1_Click);
            // 
            // tbNote1
            // 
            this.tbNote1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNote1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNote1.Location = new System.Drawing.Point(17, 50);
            this.tbNote1.Multiline = true;
            this.tbNote1.Name = "tbNote1";
            this.tbNote1.Size = new System.Drawing.Size(216, 223);
            this.tbNote1.TabIndex = 1;
            this.tbNote1.Text = "  Start Writing...";
            this.tbNote1.Enter += new System.EventHandler(this.tbNote1_Enter);
            this.tbNote1.Leave += new System.EventHandler(this.tbNote1_Leave);
            // 
            // panelHeaderNote1
            // 
            this.panelHeaderNote1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panelHeaderNote1.Controls.Add(this.btnClose1);
            this.panelHeaderNote1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderNote1.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderNote1.Name = "panelHeaderNote1";
            this.panelHeaderNote1.Size = new System.Drawing.Size(272, 32);
            this.panelHeaderNote1.TabIndex = 0;
            // 
            // btnClose1
            // 
            this.btnClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose1.FlatAppearance.BorderSize = 0;
            this.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose1.Image = ((System.Drawing.Image)(resources.GetObject("btnClose1.Image")));
            this.btnClose1.Location = new System.Drawing.Point(250, 3);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(19, 28);
            this.btnClose1.TabIndex = 3;
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // ucStickyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelStickyNote);
            this.Name = "ucStickyNote";
            this.Size = new System.Drawing.Size(860, 633);
            this.panelStickyNote.ResumeLayout(false);
            this.panelNote2.ResumeLayout(false);
            this.panelNote2.PerformLayout();
            this.panelHeaderNote2.ResumeLayout(false);
            this.panelNote1.ResumeLayout(false);
            this.panelNote1.PerformLayout();
            this.panelHeaderNote1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelStickyNote;
        private Panel panelNote1;
        private Panel panelHeaderNote1;
        private Button btnTrash1;
        private TextBox tbNote1;
        private Button btnClose1;
        private Button btnPlusNote;
        private Panel panelNote2;
        private Button btnTrash2;
        private TextBox tbNote2;
        private Panel panelHeaderNote2;
        private Button btnClose2;
    }
}
