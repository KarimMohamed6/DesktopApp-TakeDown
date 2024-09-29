using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Note.Models
{
    public class Notes
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public String Title { get; set; }

        public String NoteContent { get; set; }

        public int CatId { get; set; }

        public virtual Categories Cat { get; set; }


    }
}
