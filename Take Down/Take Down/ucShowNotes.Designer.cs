namespace Take_Down
{
    partial class ucShowNotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucShowNotes));
            this.panelshowNotes = new System.Windows.Forms.Panel();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rgbtnRefresh = new CustomControls.RJControls.RJButton();
            this.rjbtnSearch = new CustomControls.RJControls.RJButton();
            this.rjtbSearch = new CustomControls.RJControls.RJTextBox();
            this.panelshowNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelshowNotes
            // 
            this.panelshowNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.panelshowNotes.Controls.Add(this.dgvNotes);
            this.panelshowNotes.Controls.Add(this.panel1);
            this.panelshowNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelshowNotes.Location = new System.Drawing.Point(18, 18);
            this.panelshowNotes.Name = "panelshowNotes";
            this.panelshowNotes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 14);
            this.panelshowNotes.Size = new System.Drawing.Size(995, 707);
            this.panelshowNotes.TabIndex = 0;
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToOrderColumns = true;
            this.dgvNotes.AllowUserToResizeColumns = false;
            this.dgvNotes.AllowUserToResizeRows = false;
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotes.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNotes.ColumnHeadersHeight = 35;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotes.EnableHeadersVisualStyles = false;
            this.dgvNotes.Location = new System.Drawing.Point(4, 114);
            this.dgvNotes.MultiSelect = false;
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.RowHeadersVisible = false;
            this.dgvNotes.RowHeadersWidth = 25;
            this.dgvNotes.RowTemplate.DividerHeight = 2;
            this.dgvNotes.RowTemplate.Height = 25;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(987, 579);
            this.dgvNotes.TabIndex = 1;
            this.dgvNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellClick);
            // 
            // delete
            // 
            this.delete.FillWeight = 40F;
            this.delete.HeaderText = "Delete";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Width = 63;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.rgbtnRefresh);
            this.panel1.Controls.Add(this.rjbtnSearch);
            this.panel1.Controls.Add(this.rjtbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 109);
            this.panel1.TabIndex = 0;
            // 
            // rgbtnRefresh
            // 
            this.rgbtnRefresh.BackColor = System.Drawing.Color.White;
            this.rgbtnRefresh.BackgroundColor = System.Drawing.Color.White;
            this.rgbtnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.rgbtnRefresh.BorderRadius = 14;
            this.rgbtnRefresh.BorderSize = 3;
            this.rgbtnRefresh.FlatAppearance.BorderSize = 0;
            this.rgbtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rgbtnRefresh.ForeColor = System.Drawing.Color.White;
            this.rgbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("rgbtnRefresh.Image")));
            this.rgbtnRefresh.Location = new System.Drawing.Point(14, 3);
            this.rgbtnRefresh.Name = "rgbtnRefresh";
            this.rgbtnRefresh.Size = new System.Drawing.Size(30, 29);
            this.rgbtnRefresh.TabIndex = 9;
            this.rgbtnRefresh.TextColor = System.Drawing.Color.White;
            this.rgbtnRefresh.UseVisualStyleBackColor = false;
            this.rgbtnRefresh.Click += new System.EventHandler(this.rgbtnRefresh_Click);
            // 
            // rjbtnSearch
            // 
            this.rjbtnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnSearch.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.rjbtnSearch.BorderRadius = 14;
            this.rjbtnSearch.BorderSize = 3;
            this.rjbtnSearch.FlatAppearance.BorderSize = 0;
            this.rjbtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnSearch.ForeColor = System.Drawing.Color.White;
            this.rjbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("rjbtnSearch.Image")));
            this.rjbtnSearch.Location = new System.Drawing.Point(210, 55);
            this.rjbtnSearch.Name = "rjbtnSearch";
            this.rjbtnSearch.Size = new System.Drawing.Size(30, 29);
            this.rjbtnSearch.TabIndex = 8;
            this.rjbtnSearch.TextColor = System.Drawing.Color.White;
            this.rjbtnSearch.UseVisualStyleBackColor = false;
            this.rjbtnSearch.Click += new System.EventHandler(this.rjbtnSearch_Click);
            // 
            // rjtbSearch
            // 
            this.rjtbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbSearch.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.rjtbSearch.BorderFocusColor = System.Drawing.Color.Blue;
            this.rjtbSearch.BorderRadius = 15;
            this.rjtbSearch.BorderSize = 3;
            this.rjtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjtbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.rjtbSearch.Location = new System.Drawing.Point(14, 55);
            this.rjtbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbSearch.Multiline = false;
            this.rjtbSearch.Name = "rjtbSearch";
            this.rjtbSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbSearch.PasswordChar = false;
            this.rjtbSearch.PlaceholderColor = System.Drawing.SystemColors.ButtonShadow;
            this.rjtbSearch.PlaceholderText = " Search";
            this.rjtbSearch.Size = new System.Drawing.Size(189, 35);
            this.rjtbSearch.TabIndex = 7;
            this.rjtbSearch.Texts = "";
            this.rjtbSearch.UnderlinedStyle = false;
            // 
            // ucShowNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelshowNotes);
            this.Name = "ucShowNotes";
            this.Padding = new System.Windows.Forms.Padding(18);
            this.Size = new System.Drawing.Size(1031, 743);
            this.Load += new System.EventHandler(this.ucShowNotes_Load);
            this.panelshowNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelshowNotes;
        private DataGridView dgvNotes;
        private DataGridViewImageColumn delete;
        private Panel panel1;
        private CustomControls.RJControls.RJButton rgbtnRefresh;
        private CustomControls.RJControls.RJButton rjbtnSearch;
        private CustomControls.RJControls.RJTextBox rjtbSearch;
    }
}
