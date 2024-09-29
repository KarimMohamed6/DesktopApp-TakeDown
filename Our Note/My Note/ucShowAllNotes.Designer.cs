namespace My_Note
{
    partial class ucShowAllCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucShowAllCategories));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.rgbtnRefresh = new CustomControls.RJControls.RJButton();
            this.rjbtnSearch = new CustomControls.RJControls.RJButton();
            this.rjtbSearch = new CustomControls.RJControls.RJTextBox();
            this.paneldgvNotes = new System.Windows.Forms.Panel();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelHeader.SuspendLayout();
            this.paneldgvNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.panelHeader.Controls.Add(this.rgbtnRefresh);
            this.panelHeader.Controls.Add(this.rjbtnSearch);
            this.panelHeader.Controls.Add(this.rjtbSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(18, 18);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(9);
            this.panelHeader.Size = new System.Drawing.Size(757, 123);
            this.panelHeader.TabIndex = 0;
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
            this.rgbtnRefresh.Location = new System.Drawing.Point(14, 12);
            this.rgbtnRefresh.Name = "rgbtnRefresh";
            this.rgbtnRefresh.Size = new System.Drawing.Size(30, 29);
            this.rgbtnRefresh.TabIndex = 6;
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
            this.rjbtnSearch.Location = new System.Drawing.Point(201, 62);
            this.rjbtnSearch.Name = "rjbtnSearch";
            this.rjbtnSearch.Size = new System.Drawing.Size(30, 29);
            this.rjbtnSearch.TabIndex = 3;
            this.rjbtnSearch.TextColor = System.Drawing.Color.White;
            this.rjbtnSearch.UseVisualStyleBackColor = false;
            this.rjbtnSearch.Click += new System.EventHandler(this.rjbtnSearch_Click);
            // 
            // rjtbSearch
            // 
            this.rjtbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtbSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.rjtbSearch.BorderRadius = 15;
            this.rjtbSearch.BorderSize = 3;
            this.rjtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjtbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.rjtbSearch.Location = new System.Drawing.Point(14, 62);
            this.rjtbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbSearch.Multiline = false;
            this.rjtbSearch.Name = "rjtbSearch";
            this.rjtbSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbSearch.PasswordChar = false;
            this.rjtbSearch.PlaceholderColor = System.Drawing.SystemColors.ButtonShadow;
            this.rjtbSearch.PlaceholderText = " Search";
            this.rjtbSearch.Size = new System.Drawing.Size(189, 35);
            this.rjtbSearch.TabIndex = 2;
            this.rjtbSearch.Texts = "";
            this.rjtbSearch.UnderlinedStyle = false;
            // 
            // paneldgvNotes
            // 
            this.paneldgvNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.paneldgvNotes.Controls.Add(this.dgvNotes);
            this.paneldgvNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldgvNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.paneldgvNotes.Location = new System.Drawing.Point(18, 141);
            this.paneldgvNotes.Margin = new System.Windows.Forms.Padding(0);
            this.paneldgvNotes.Name = "paneldgvNotes";
            this.paneldgvNotes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 14);
            this.paneldgvNotes.Size = new System.Drawing.Size(757, 479);
            this.paneldgvNotes.TabIndex = 1;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotes.ColumnHeadersHeight = 35;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotes.EnableHeadersVisualStyles = false;
            this.dgvNotes.Location = new System.Drawing.Point(4, 5);
            this.dgvNotes.MultiSelect = false;
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.RowHeadersVisible = false;
            this.dgvNotes.RowHeadersWidth = 25;
            this.dgvNotes.RowTemplate.DividerHeight = 2;
            this.dgvNotes.RowTemplate.Height = 25;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(749, 460);
            this.dgvNotes.TabIndex = 0;
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
            // ucShowAllCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.paneldgvNotes);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucShowAllCategories";
            this.Padding = new System.Windows.Forms.Padding(18);
            this.Size = new System.Drawing.Size(793, 638);
            this.Load += new System.EventHandler(this.ucShowAllCategories_Load);
            this.panelHeader.ResumeLayout(false);
            this.paneldgvNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private Panel paneldgvNotes;
        private DataGridView dgvNotes;
        private CustomControls.RJControls.RJTextBox rjtbSearch;
        private CustomControls.RJControls.RJButton rjbtnSearch;
        private DataGridViewImageColumn delete;
        private CustomControls.RJControls.RJButton rgbtnRefresh;
    }
}
