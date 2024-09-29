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
    public partial class ucAddNote : UserControl
    {
        db db = new db();
        DateTime dt = DateTime.UtcNow;
        public ucAddNote()
        {
            InitializeComponent();
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


       

        #region Title TextBox

        private void textBoxTitle_Enter(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "  Title")
            {
                textBoxTitle.Text = "";
                textBoxTitle.ForeColor = Color.Black;
            }
        }

        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                textBoxTitle.Text = "  Title";
                textBoxTitle.ForeColor = Color.Silver;

            }
        }

        #endregion Title TextBox 

        #region Note TextBox

        private void textBoxNote_Enter(object sender, EventArgs e)
        {
            if (textBoxNote.Text == "  Start Writing...")
            {
                textBoxNote.Text = "";
                textBoxNote.ForeColor = Color.Black;
            }
        }

        private void textBoxNote_Leave(object sender, EventArgs e)
        {
            if (textBoxNote.Text == "")
            {
                textBoxNote.Text = "  Start Writing...";
                textBoxNote.ForeColor = Color.Silver;

            }
        }



        #endregion Note TextBox

        #region Trash Button

        private void btnTrash_Click(object sender, EventArgs e)
        {
          

            textBoxTitle.Text = " Title";
            textBoxTitle.ForeColor = Color.Silver;

            textBoxNote.Text = "  Start Writing...";
            textBoxNote.ForeColor = Color.Silver;

         
        }

        #endregion

        #region ComboBox

         public  void fillCombo()
        {
            comboBox1.DataSource = (from Categories in db.Categories
                                       select new { Categories.Kind, Categories.Id }).ToList();

            comboBox1.DisplayMember = "Kind";
            comboBox1.ValueMember = "Id";


            db.SaveChanges();

        }

        #endregion

        #region Data Base

        public void addNote()
        {
            if (textBoxTitle.Text == "" || textBoxTitle.Text == "  Title")
            {
                MessageBox.Show("Please, Enter The Title Of Your Note.");
            }

            else if (textBoxNote.Text == "" || textBoxNote.Text == "  Start Writing...")
            {

                Notes note = new Notes()
                {
                    Date = dt.ToString("dd/MM/yyyy"),

                    Title = textBoxTitle.Text,

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

                    Title = textBoxTitle.Text,

                    NoteContent = textBoxNote.Text,

                    CatId = int.Parse(comboBox1.SelectedValue.ToString()),


                };

                db.Notes.Add(note);
                db.SaveChanges();



                MessageBox.Show("Saved Successfuly");

            }


            textBoxNote.Text = "";
            textBoxTitle.Text = "";

        }

        #endregion




    }
}
