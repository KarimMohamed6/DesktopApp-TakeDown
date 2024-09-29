using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace Take_Down.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public String Kind { get; set; }

        public virtual List<Notes> Notes { get; set; }
    }
}
