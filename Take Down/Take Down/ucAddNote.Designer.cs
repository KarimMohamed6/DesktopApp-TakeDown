namespace Take_Down
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjtbNote = new CustomControls.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            this.rjtbTitle = new CustomControls.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTrash = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.rjtbNote);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnTrash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 743);
            this.panel1.TabIndex = 0;
            // 
            // rjtbNote
            // 
            this.rjtbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjtbNote.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbNote.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtbNote.BorderFocusColor = System.Drawing.Color.Blue;
            this.rjtbNote.BorderRadius = 8;
            this.rjtbNote.BorderSize = 2;
            this.rjtbNote.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjtbNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjtbNote.Location = new System.Drawing.Point(20, 132);
            this.rjtbNote.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbNote.Multiline = true;
            this.rjtbNote.Name = "rjtbNote";
            this.rjtbNote.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbNote.PasswordChar = false;
            this.rjtbNote.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbNote.PlaceholderText = "  Start Writing...";
            this.rjtbNote.Size = new System.Drawing.Size(940, 506);
            this.rjtbNote.TabIndex = 10;
            this.rjtbNote.Texts = "";
            this.rjtbNote.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(156)))), ((int)(((byte)(208)))));
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.rjComboBox1);
            this.panel2.Controls.Add(this.rjtbTitle);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 125);
            this.panel2.TabIndex = 11;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderSize = 2;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(20, 20);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.rjComboBox1.Size = new System.Drawing.Size(299, 35);
            this.rjComboBox1.TabIndex = 6;
            this.rjComboBox1.Texts = "Choose Category";
            this.rjComboBox1.Enter += new System.EventHandler(this.rjComboBox1_Enter);
            // 
            // rjtbTitle
            // 
            this.rjtbTitle.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbTitle.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtbTitle.BorderFocusColor = System.Drawing.Color.Blue;
            this.rjtbTitle.BorderRadius = 8;
            this.rjtbTitle.BorderSize = 2;
            this.rjtbTitle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjtbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjtbTitle.Location = new System.Drawing.Point(20, 86);
            this.rjtbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTitle.Multiline = false;
            this.rjtbTitle.Name = "rjtbTitle";
            this.rjtbTitle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbTitle.PasswordChar = false;
            this.rjtbTitle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbTitle.PlaceholderText = " Title";
            this.rjtbTitle.Size = new System.Drawing.Size(312, 35);
            this.rjtbTitle.TabIndex = 5;
            this.rjtbTitle.Texts = "";
            this.rjtbTitle.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(820, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(20, 699);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash.Image")));
            this.btnTrash.Location = new System.Drawing.Point(74, 699);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(19, 28);
            this.btnTrash.TabIndex = 8;
            this.btnTrash.UseVisualStyleBackColor = true;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            // 
            // ucAddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ucAddNote";
            this.Size = new System.Drawing.Size(975, 743);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private Button btnTrash;
        private Panel panel2;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        private CustomControls.RJControls.RJTextBox rjtbTitle;
        private PictureBox pictureBox1;
        private CustomControls.RJControls.RJTextBox rjtbNote;
        private ComboBox comboBox1;
    }
}
