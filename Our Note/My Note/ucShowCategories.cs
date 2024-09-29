using My_Note.Models;
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
    public partial class ucShowCategories : UserControl
    {
        db db = new db();
        DateTime dt = DateTime.UtcNow;

        public ucShowCategories()
        {
            InitializeComponent();
        }

        private void ucShowCategories_Load(object sender, EventArgs e)
        {
            showAll();
        }

        private void rjbtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void rjbtnSsve_Click(object sender, EventArgs e)
        {
            addCategory();
            showAll();
        }

        
             #region Data Base

        public void showAll()
        {
            var allCategories = db.Categories.Select(c => new { Date = c.Date, Kind = c.Kind }).ToList();

            dgvCategories.DataSource = allCategories;

        }


        public void Search()
        {
            var search = db.Categories.Where(c => c.Kind.ToLower().Contains(rjtbSearch.Texts.ToLower()))
                                         .Select((c => new { Date = c.Date, Kind = c.Kind })).ToList();

            dgvCategories.DataSource = search;
        }

        #region Add
        public void addCategory()
        {
            int f = 0;
            var existName = db.Categories.Select(c => c.Kind);
            foreach (var c in existName)
            {
                if (c == rjtbAdd.Texts)
                {
                    f = 1;
                    break;
                }

            }

            if (rjtbAdd.Texts != "" && f == 0)
            {

                Categories cat = new Categories()
                {
                    Date = dt.ToString("dd/MM/yyyy"),
                    Kind = rjtbAdd.Texts,
                };

                db.Categories.Add(cat);
                db.SaveChanges();

                rjtbAdd.Texts = "";

                MessageBox.Show("Successfuly Saved ⩗");


            }

            else if (rjtbAdd.Texts == "")
            {
                MessageBox.Show("Please, Enter The Name OF Category!!");
                rjtbAdd.Texts = "";
            }
            else if (f == 1)
            {
                MessageBox.Show("This Category Already Exist, With The Same Name!!");
                rjtbAdd.Texts = "";

            }

        }

        #endregion

        #region Delete
        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategories.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                var name = dgvCategories.Rows[e.RowIndex].Cells["Kind"].Value.ToString();

                DialogResult confirm = MessageBox.Show("Are You Sure You Want To Delete This Category And It's Notes", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    db.Remove(db.Categories.Single(c => c.Kind == name));
                    db.SaveChanges();
                    showAll();
                }

            }
        }

        #endregion


        #endregion




    }
}
