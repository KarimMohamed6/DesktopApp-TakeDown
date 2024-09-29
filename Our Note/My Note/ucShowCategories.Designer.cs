namespace My_Note
{
    partial class ucShowCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucShowCategories));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneldgvCategories = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.rjbtnSsve = new CustomControls.RJControls.RJButton();
            this.rjtbAdd = new CustomControls.RJControls.RJTextBox();
            this.rjbtnSearch = new CustomControls.RJControls.RJButton();
            this.rjtbSearch = new CustomControls.RJControls.RJTextBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.delet = new System.Windows.Forms.DataGridViewImageColumn();
            this.paneldgvCategories.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldgvCategories
            // 
            this.paneldgvCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.paneldgvCategories.Controls.Add(this.panelHeader);
            this.paneldgvCategories.Controls.Add(this.dgvCategories);
            this.paneldgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldgvCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.paneldgvCategories.Location = new System.Drawing.Point(18, 18);
            this.paneldgvCategories.Margin = new System.Windows.Forms.Padding(0);
            this.paneldgvCategories.Name = "paneldgvCategories";
            this.paneldgvCategories.Padding = new System.Windows.Forms.Padding(4, 10, 4, 14);
            this.paneldgvCategories.Size = new System.Drawing.Size(757, 602);
            this.paneldgvCategories.TabIndex = 2;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.panelHeader.Controls.Add(this.rjbtnSsve);
            this.panelHeader.Controls.Add(this.rjtbAdd);
            this.panelHeader.Controls.Add(this.rjbtnSearch);
            this.panelHeader.Controls.Add(this.rjtbSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(4, 10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(9);
            this.panelHeader.Size = new System.Drawing.Size(749, 97);
            this.panelHeader.TabIndex = 1;
            // 
            // rjbtnSsve
            // 
            this.rjbtnSsve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjbtnSsve.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnSsve.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnSsve.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnSsve.BorderRadius = 0;
            this.rjbtnSsve.BorderSize = 0;
            this.rjbtnSsve.FlatAppearance.BorderSize = 0;
            this.rjbtnSsve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnSsve.ForeColor = System.Drawing.Color.White;
            this.rjbtnSsve.Location = new System.Drawing.Point(643, 26);
            this.rjbtnSsve.Name = "rjbtnSsve";
            this.rjbtnSsve.Size = new System.Drawing.Size(78, 29);
            this.rjbtnSsve.TabIndex = 5;
            this.rjbtnSsve.Text = "Save";
            this.rjbtnSsve.TextColor = System.Drawing.Color.White;
            this.rjbtnSsve.UseVisualStyleBackColor = false;
            this.rjbtnSsve.Click += new System.EventHandler(this.rjbtnSsve_Click);
            // 
            // rjtbAdd
            // 
            this.rjtbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjtbAdd.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbAdd.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtbAdd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.rjtbAdd.BorderRadius = 15;
            this.rjtbAdd.BorderSize = 3;
            this.rjtbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjtbAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.rjtbAdd.Location = new System.Drawing.Point(416, 20);
            this.rjtbAdd.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbAdd.Multiline = false;
            this.rjtbAdd.Name = "rjtbAdd";
            this.rjtbAdd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbAdd.PasswordChar = false;
            this.rjtbAdd.PlaceholderColor = System.Drawing.SystemColors.ButtonShadow;
            this.rjtbAdd.PlaceholderText = "+ Add New";
            this.rjtbAdd.Size = new System.Drawing.Size(189, 35);
            this.rjtbAdd.TabIndex = 4;
            this.rjtbAdd.Texts = "";
            this.rjtbAdd.UnderlinedStyle = false;
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
            this.rjbtnSearch.Location = new System.Drawing.Point(228, 26);
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
            this.rjtbSearch.Location = new System.Drawing.Point(22, 20);
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
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToOrderColumns = true;
            this.dgvCategories.AllowUserToResizeColumns = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategories.ColumnHeadersHeight = 35;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delet});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategories.EnableHeadersVisualStyles = false;
            this.dgvCategories.Location = new System.Drawing.Point(26, 113);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowHeadersWidth = 25;
            this.dgvCategories.RowTemplate.DividerHeight = 2;
            this.dgvCategories.RowTemplate.Height = 25;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(699, 369);
            this.dgvCategories.TabIndex = 0;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellClick);
            // 
            // delet
            // 
            this.delet.FillWeight = 20F;
            this.delet.HeaderText = "Delete";
            this.delet.Image = ((System.Drawing.Image)(resources.GetObject("delet.Image")));
            this.delet.MinimumWidth = 6;
            this.delet.Name = "delet";
            // 
            // ucShowCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paneldgvCategories);
            this.Name = "ucShowCategories";
            this.Padding = new System.Windows.Forms.Padding(18);
            this.Size = new System.Drawing.Size(793, 638);
            this.Load += new System.EventHandler(this.ucShowCategories_Load);
            this.paneldgvCategories.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel paneldgvCategories;
        private DataGridView dgvCategories;
        private Panel panelHeader;
        private CustomControls.RJControls.RJButton rjbtnSearch;
        private CustomControls.RJControls.RJTextBox rjtbSearch;
        private CustomControls.RJControls.RJTextBox rjtbAdd;
        private CustomControls.RJControls.RJButton rjbtnSsve;
        private DataGridViewImageColumn delet;
    }
}
