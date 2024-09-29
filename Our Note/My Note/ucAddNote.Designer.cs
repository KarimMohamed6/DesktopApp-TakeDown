namespace My_Note
{
    partial class ucAddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddNote));
            this.panelAddNotte = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTrash = new System.Windows.Forms.Button();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAddNotte.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddNotte
            // 
            this.panelAddNotte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.panelAddNotte.Controls.Add(this.comboBox1);
            this.panelAddNotte.Controls.Add(this.btnTrash);
            this.panelAddNotte.Controls.Add(this.textBoxNote);
            this.panelAddNotte.Controls.Add(this.textBoxTitle);
            this.panelAddNotte.Controls.Add(this.panelHeader);
            this.panelAddNotte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddNotte.Location = new System.Drawing.Point(0, 0);
            this.panelAddNotte.Name = "panelAddNotte";
            this.panelAddNotte.Size = new System.Drawing.Size(941, 661);
            this.panelAddNotte.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 160;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = " Choose Exest Category";
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            // 
            // btnTrash
            // 
            this.btnTrash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash.Image")));
            this.btnTrash.Location = new System.Drawing.Point(80, 615);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(19, 28);
            this.btnTrash.TabIndex = 5;
            this.btnTrash.UseVisualStyleBackColor = true;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNote.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNote.Location = new System.Drawing.Point(24, 168);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(887, 394);
            this.textBoxNote.TabIndex = 3;
            this.textBoxNote.Text = "  Start Writing...";
            this.textBoxNote.Enter += new System.EventHandler(this.textBoxNote_Enter);
            this.textBoxNote.Leave += new System.EventHandler(this.textBoxNote_Leave);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTitle.Location = new System.Drawing.Point(24, 123);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(288, 27);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = "  Title";
            this.textBoxTitle.Enter += new System.EventHandler(this.textBoxTitle_Enter);
            this.textBoxTitle.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(156)))), ((int)(((byte)(208)))));
            this.panelHeader.Controls.Add(this.btnSave);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(941, 79);
            this.panelHeader.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(24, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucAddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAddNotte);
            this.Name = "ucAddNote";
            this.Size = new System.Drawing.Size(941, 661);
            this.panelAddNotte.ResumeLayout(false);
            this.panelAddNotte.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAddNotte;
        private TextBox textBoxNote;
        private TextBox textBoxTitle;
        private Panel panelHeader;
        private Button btnSave;
        private Button btnTrash;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
    }
}
