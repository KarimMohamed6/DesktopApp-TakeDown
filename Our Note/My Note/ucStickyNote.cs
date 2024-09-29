using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Note
{
    public partial class ucStickyNote : UserControl 
    {
        public ucStickyNote()
        {
            InitializeComponent();
        }


        #region Note One

        private void btnClose1_Click(object sender, EventArgs e)
        {
            panelNote1.Hide();
        }

        private void btnTrash1_Click(object sender, EventArgs e)
        {
            tbNote1.Text = "  Start Writing...";
            tbNote1.ForeColor = Color.Silver;
        }

        private void tbNote1_Enter(object sender, EventArgs e)
        {
            if (tbNote1.Text == "  Start Writing...")
            {
                tbNote1.Text = "";
                tbNote1.ForeColor = Color.Black;
            }
        }

        private void tbNote1_Leave(object sender, EventArgs e)
        {
            if (tbNote1.Text == "")
            {
                tbNote1.Text = "  Start Writing...";
                tbNote1.ForeColor = Color.Silver;

            }
        }

        #endregion

        #region Note Two

        private void btnClose2_Click(object sender, EventArgs e)
        {
            panelNote2.Hide();
        }

        private void btnTrash2_Click(object sender, EventArgs e)
        {
            tbNote2.Text = "  Start Writing...";
            tbNote2.ForeColor = Color.Silver;
        }

        private void tbNote2_Enter(object sender, EventArgs e)
        {
            if (tbNote2.Text == "  Start Writing...")
            {
                tbNote2.Text = "";
                tbNote2.ForeColor = Color.Black;
            }
        }

        private void tbNote2_Leave(object sender, EventArgs e)
        {
            if (tbNote2.Text == "")
            {
                tbNote2.Text = "  Start Writing...";
                tbNote2.ForeColor = Color.Silver;

            }
        }
        #endregion
       
      
    }
}
