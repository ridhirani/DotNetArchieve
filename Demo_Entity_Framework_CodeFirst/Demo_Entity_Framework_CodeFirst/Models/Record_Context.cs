using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Entity_Framework_CodeFirst;
using Microsoft.EntityFrameworkCore;

namespace Demo_Entity_Framework_CodeFirst.Models
{
    public class Record_Context: DbContext
    {
        public Record_Context():base("RecordContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(Model modelBuilder)
        {
            modelBuilder.Con
        } 
    }
}
