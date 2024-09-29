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
    public partial class ucShowAllCategories : UserControl
    {
        db db = new db();
        public ucShowAllCategories()
        {
            InitializeComponent();
           
        }

        private void ucShowAllCategories_Load(object sender, EventArgs e)
        {
            showAll();
            dgvNotes.Columns["Content"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvNotes.Columns["Content"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void rjbtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void rgbtnRefresh_Click(object sender, EventArgs e)
        {
            showAll();
        }

        #region Data Base

        public void showAll()
        {
            var allNotes = db.Notes.Select(n => new { Date = n.Date, Category = n.Cat.Kind, Title = n.Title, Content = n.NoteContent }).ToList();

            dgvNotes.DataSource = allNotes;

        }


        public void Search()
        {
            var search = db.Notes.Where(n => n.Title.ToLower().Contains(rjtbSearch.Texts.ToLower()) ||
                                         n.Date.Contains(rjtbSearch.Texts))
                                       .Select(n => new { Date = n.Date, Category = n.Cat.Kind, Title = n.Title, Content = n.NoteContent }).ToList();

            dgvNotes.DataSource = search;
        }


        private void dgvNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNotes.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id = 0, f = 0;
                String title = dgvNotes.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                String content = dgvNotes.Rows[e.RowIndex].Cells["Content"].Value.ToString();
                String date = dgvNotes.Rows[e.RowIndex].Cells["Date"].Value.ToString();


                var list = db.Notes.Select(n => new { n.Id, n.Title, n.NoteContent, n.Date });

                foreach (var item in list)
                {
                    if (item.Title == title && item.NoteContent == content && item.Date == date)
                    {
                        id = item.Id;
                        f = 1;
                        break;
                    }

                }

                DialogResult confirm = MessageBox.Show("Do You Sure You Want To Delete This Note ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    if (f == 1)
                    {
                        db.Remove(db.Notes.Single(n => n.Id == id));

                        db.SaveChanges();
                        showAll();
                    }

                }

            }
        }




        #endregion

        
    }
}
