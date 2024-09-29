using CustomControls.RJControls;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace My_Note
{
    public partial class Form1  : Form
    {
        private int borderSize = 2;
        public Form1()
        {
            InitializeComponent();
            start();
            collapseMenu();
        }

        #region Form

        public void start()
        {
            this.Padding = new Padding(borderSize); //border size
            this.BackColor = Color.FromArgb(98, 102, 244);//border color

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Minimized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }

        }


        #endregion

        #region Header Panel

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        private void btnMaxmize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Drag  The Form from The Header panel
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCIZE = 0x0083;
            if (m.Msg == WM_NCCALCIZE && m.WParam.ToInt32() == 1)
                return;
            base.WndProc(ref m);
        }


        #endregion

        #region Menu Panel

        private void ibtnMenu_Click(object sender, EventArgs e)
        {
            collapseMenu();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelScroll.Height = btnHome.Height;
            panelScroll.Top = btnHome.Top;

            this.ucHome1.BringToFront();
            this.ucHome1.Visible = true;
            this.ucStickyNote1.Visible = false;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            panelScroll.Height = btnCategories.Height;
            panelScroll.Top = btnCategories.Top;

            Open_DropDownMenu(rjDropdownMenu2, sender);
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            panelScroll.Height = btnNewNote.Height;
            panelScroll.Top = btnNewNote.Top;

            Open_DropDownMenu(rjDropdownMenu1, sender);
            
        }

        private void btnStickyNotes_Click(object sender, EventArgs e)
        {
            panelScroll.Height = btnStickyNotes.Height;
            panelScroll.Top = btnStickyNotes.Top;

            ucStickyNote1.BringToFront();
            this.ucStickyNote1.Visible = true;
            this.ucHome1.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panelScroll.Height = btnSettings.Height;
            panelScroll.Top = btnSettings.Top;
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            panelScroll.Height = btnAboutUs.Height;
            panelScroll.Top = btnAboutUs.Top;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region DropDownMenu

        //Categories Button

        private void showAllCategoryTSMItem_Click(object sender, EventArgs e)
        {
            this.ucShowCategories1.BringToFront();
            this.ucShowCategories1.Visible = true;
            this.ucStickyNote1.Visible = false;
            this.ucHome1.Visible = false;
            this.ucAddNote1.Visible = false;
        }

        //My Notes Button
        private void addNewTSMItem_Click(object sender, EventArgs e)
        {

            this.ucAddNote1.BringToFront();
            this.ucAddNote1.Visible = true;
            this.ucHome1.Visible = false;
            this.ucStickyNote1.Visible = false;
        }

        private void showAllTSMItem_Click(object sender, EventArgs e)
        {
            this.ucShowAllNotes1.BringToFront();
            this.ucShowAllNotes1.Visible = true;
            this.ucStickyNote1.Visible = false;
            this.ucHome1.Visible = false;
            this.ucAddNote1.Visible = false;
        }

        #endregion


        #region Some Functions

        //Menu Button
        private void collapseMenu()
        {

            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pbLogo.Visible = false;
                ibtnMenu.Dock = DockStyle.Top;
                foreach (Button menubtn in this.panelMenu.Controls.OfType<Button>())
                {
                    menubtn.Text = "";
                    menubtn.ImageAlign = ContentAlignment.MiddleCenter;
                    menubtn.Padding = new Padding(0);

                }
            }
            else
            {
                panelMenu.Width = 240;
                pbLogo.Visible = true;
                ibtnMenu.Dock = DockStyle.None;
                foreach (Button menubtn in this.panelMenu.Controls.OfType<Button>())
                {
                    menubtn.Text = menubtn.Tag.ToString();
                    menubtn.ImageAlign = ContentAlignment.MiddleLeft;
                    menubtn.Padding = new Padding(10, 0, 0, 0);

                }
            }
        }


        //My Notes Button
        private void Open_DropDownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev) =>
            dropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }

        private void dropdownMenu_VisibleChanged(object sender, EventArgs ev, Control control)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                    control.BackColor = Color.FromArgb(159, 161, 224);
                else
                    control.BackColor = Color.FromArgb(98, 102, 224);
            }
        }




        #endregion

        #endregion

       
    }
}