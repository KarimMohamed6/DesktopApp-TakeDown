using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Down.Models
{
    public class db : DbContext
    {
        public DbSet<Categories> Categories { get; set; }

        public DbSet<Notes> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server= LAPTOP-929IVL1G;Database= Take Down;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
