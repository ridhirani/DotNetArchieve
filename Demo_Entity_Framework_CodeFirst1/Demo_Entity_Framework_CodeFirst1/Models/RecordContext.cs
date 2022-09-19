using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Entity_Framework_CodeFirst1.Models
{
    public class RecordContext : DbContext
    {
        public RecordContext() : base()
        {

        }
        public DbSet<Student> Students_Ridhief { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=192.168.1.230;Initial Catalog=Freshers_Training2022;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022");

        }
    }

}
