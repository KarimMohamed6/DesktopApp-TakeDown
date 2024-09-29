using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Take_Down.Models;

namespace Take_Down
{
    public partial class ucAddNote : UserControl
    {

        db db = new db();
        DateTime dt = DateTime.UtcNow;

        public ucAddNote()
        {
            InitializeComponent();
        }


       

        private void rjComboBox1_Enter(object sender, EventArgs e)
        {
            fillCombo();
        }
        private void comboBox1_Enter(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addNote();
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            rjtbNote.Texts = "";
            rjtbTitle.Texts = "";
        }

        #region ComboBox

        public void fillCombo()
        {
            comboBox1.DataSource = (from Categories in db.Categories
                                      select new { Categories.Kind, Categories.Id }).ToList();

            comboBox1.DisplayMember = "Kind";
            comboBox1.ValueMember = "Id";


            rjComboBox1.DataSource = (from Categories in db.Categories
                                    select new { Categories.Kind, Categories.Id }).ToList();

            rjComboBox1.DisplayMember = "Kind";
            rjComboBox1.ValueMember = "Id";



            db.SaveChanges();

        }

        #endregion

        #region Data Base

        public void addNote()
        {
            if (rjtbTitle.Texts == "" )
            {
                MessageBox.Show("Please, Enter The Title Of Your Note.");
            }

            else if (rjtbNote.Texts == "")
            {

                Notes note = new Notes()
                {
                    Date = dt.ToString("dd/MM/yyyy"),

                    Title = rjtbTitle.Texts,

                    NoteContent = "",

                    CatId = int.Parse(comboBox1.SelectedValue.ToString()),


                };

                db.Notes.Add(note);
                db.SaveChanges();


                MessageBox.Show("Your Note Saved But, It Is Empty.");
            }

            else
            {
                Notes note = new Notes()
                {
                    Date = dt.ToString("dd/MM/yyyy"),

                    Title = rjtbTitle.Texts,

                    NoteContent = rjtbNote.Texts,

                    CatId = int.Parse(comboBox1.SelectedValue.ToString()),


                };

                db.Notes.Add(note);
                db.SaveChanges();



                MessageBox.Show("Saved Successfuly");

            }


            rjtbNote.Texts = "";
            rjtbTitle.Texts = "";

        }

        #endregion

    }
}
