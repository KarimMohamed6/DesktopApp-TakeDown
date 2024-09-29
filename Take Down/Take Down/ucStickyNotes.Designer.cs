namespace Take_Down
{
    partial class ucStickyNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStickyNotes));
            this.panelStickyNotes = new System.Windows.Forms.Panel();
            this.panelNote1 = new System.Windows.Forms.Panel();
            this.panelNote2 = new System.Windows.Forms.Panel();
            this.panelHeaderNote1 = new System.Windows.Forms.Panel();
            this.panelHeaderNote2 = new System.Windows.Forms.Panel();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnPlusNote = new System.Windows.Forms.Button();
            this.btnTrash1 = new System.Windows.Forms.Button();
            this.btnTrash2 = new System.Windows.Forms.Button();
            this.rjtbNote1 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.panelStickyNotes.SuspendLayout();
            this.panelNote1.SuspendLayout();
            this.panelNote2.SuspendLayout();
            this.panelHeaderNote1.SuspendLayout();
            this.panelHeaderNote2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStickyNotes
            // 
            this.panelStickyNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.panelStickyNotes.Controls.Add(this.btnPlusNote);
            this.panelStickyNotes.Controls.Add(this.panelNote2);
            this.panelStickyNotes.Controls.Add(this.panelNote1);
            this.panelStickyNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStickyNotes.Location = new System.Drawing.Point(2, 2);
            this.panelStickyNotes.Name = "panelStickyNotes";
            this.panelStickyNotes.Size = new System.Drawing.Size(954, 717);
            this.panelStickyNotes.TabIndex = 0;
            // 
            // panelNote1
            // 
            this.panelNote1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.panelNote1.Controls.Add(this.rjtbNote1);
            this.panelNote1.Controls.Add(this.btnTrash1);
            this.panelNote1.Controls.Add(this.panelHeaderNote1);
            this.panelNote1.Location = new System.Drawing.Point(68, 70);
            this.panelNote1.Name = "panelNote1";
            this.panelNote1.Size = new System.Drawing.Size(291, 363);
            this.panelNote1.TabIndex = 0;
            // 
            // panelNote2
            // 
            this.panelNote2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.panelNote2.Controls.Add(this.rjTextBox2);
            this.panelNote2.Controls.Add(this.btnTrash2);
            this.panelNote2.Controls.Add(this.panelHeaderNote2);
            this.panelNote2.Location = new System.Drawing.Point(538, 72);
            this.panelNote2.Name = "panelNote2";
            this.panelNote2.Size = new System.Drawing.Size(291, 363);
            this.panelNote2.TabIndex = 1;
            // 
            // panelHeaderNote1
            // 
            this.panelHeaderNote1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.panelHeaderNote1.Controls.Add(this.btnClose1);
            this.panelHeaderNote1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderNote1.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderNote1.Name = "panelHeaderNote1";
            this.panelHeaderNote1.Size = new System.Drawing.Size(291, 34);
            this.panelHeaderNote1.TabIndex = 0;
            // 
            // panelHeaderNote2
            // 
            this.panelHeaderNote2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.panelHeaderNote2.Controls.Add(this.btnClose2);
            this.panelHeaderNote2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderNote2.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderNote2.Name = "panelHeaderNote2";
            this.panelHeaderNote2.Size = new System.Drawing.Size(291, 34);
            this.panelHeaderNote2.TabIndex = 0;
            // 
            // btnClose1
            // 
            this.btnClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose1.FlatAppearance.BorderSize = 0;
            this.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose1.Image = ((System.Drawing.Image)(resources.GetObject("btnClose1.Image")));
            this.btnClose1.Location = new System.Drawing.Point(267, 2);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(19, 28);
            this.btnClose1.TabIndex = 4;
            this.btnClose1.UseVisualStyleBackColor = true;
            // 
            // btnClose2
            // 
            this.btnClose2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose2.FlatAppearance.BorderSize = 0;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Image = ((System.Drawing.Image)(resources.GetObject("btnClose2.Image")));
            this.btnClose2.Location = new System.Drawing.Point(267, 2);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(19, 28);
            this.btnClose2.TabIndex = 5;
            this.btnClose2.UseVisualStyleBackColor = true;
            // 
            // btnPlusNote
            // 
            this.btnPlusNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlusNote.FlatAppearance.BorderSize = 0;
            this.btnPlusNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusNote.Image = ((System.Drawing.Image)(resources.GetObject("btnPlusNote.Image")));
            this.btnPlusNote.Location = new System.Drawing.Point(187, 564);
            this.btnPlusNote.Name = "btnPlusNote";
            this.btnPlusNote.Size = new System.Drawing.Size(67, 72);
            this.btnPlusNote.TabIndex = 6;
            this.btnPlusNote.UseVisualStyleBackColor = true;
            // 
            // btnTrash1
            // 
            this.btnTrash1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrash1.FlatAppearance.BorderSize = 0;
            this.btnTrash1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash1.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash1.Image")));
            this.btnTrash1.Location = new System.Drawing.Point(10, 326);
            this.btnTrash1.Name = "btnTrash1";
            this.btnTrash1.Size = new System.Drawing.Size(19, 28);
            this.btnTrash1.TabIndex = 5;
            this.btnTrash1.UseVisualStyleBackColor = true;
            // 
            // btnTrash2
            // 
            this.btnTrash2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrash2.FlatAppearance.BorderSize = 0;
            this.btnTrash2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash2.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash2.Image")));
            this.btnTrash2.Location = new System.Drawing.Point(9, 326);
            this.btnTrash2.Name = "btnTrash2";
            this.btnTrash2.Size = new System.Drawing.Size(19, 28);
            this.btnTrash2.TabIndex = 7;
            this.btnTrash2.UseVisualStyleBackColor = true;
            // 
            // rjtbNote1
            // 
            this.rjtbNote1.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbNote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.rjtbNote1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtbNote1.BorderRadius = 0;
            this.rjtbNote1.BorderSize = 2;
            this.rjtbNote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjtbNote1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjtbNote1.Location = new System.Drawing.Point(7, 37);
            this.rjtbNote1.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbNote1.Multiline = true;
            this.rjtbNote1.Name = "rjtbNote1";
            this.rjtbNote1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbNote1.PasswordChar = false;
            this.rjtbNote1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbNote1.PlaceholderText = "  Write Down..";
            this.rjtbNote1.Size = new System.Drawing.Size(276, 278);
            this.rjtbNote1.TabIndex = 6;
            this.rjtbNote1.Texts = "";
            this.rjtbNote1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 0;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(9, 37);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = true;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "  Write Down..";
            this.rjTextBox2.Size = new System.Drawing.Size(276, 278);
            this.rjTextBox2.TabIndex = 7;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // ucStickyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.panelStickyNotes);
            this.Name = "ucStickyNotes";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(958, 721);
            this.panelStickyNotes.ResumeLayout(false);
            this.panelNote1.ResumeLayout(false);
            this.panelNote2.ResumeLayout(false);
            this.panelHeaderNote1.ResumeLayout(false);
            this.panelHeaderNote2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelStickyNotes;
        private Panel panelNote2;
        private Panel panelHeaderNote2;
        private Panel panelNote1;
        private Panel panelHeaderNote1;
        private Button btnPlusNote;
        private Button btnTrash2;
        private Button btnClose2;
        private Button btnTrash1;
        private Button btnClose1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private CustomControls.RJControls.RJTextBox rjtbNote1;
    }
}
