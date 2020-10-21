using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class ProfessorContext : DbContext
    {
        public ProfessorContext(DbContextOptions<ProfessorContext> options)
            :base(options)
        {

        }

        public DbSet<Professor> Professors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Professor>().HasData
                  (new Professor
                  {
                      ProfessorID = 1,
                      FirstName = "Michael",
                      LastName = "Redmond",
                      Building = "Holroyd",
                      OfficeNumber = "131",
                      PhoneNumber = "2111111111",
                      EmailAddress = "redmond@lasalle.edu",
                      Department = " Mathematics and Computer Science",
                      Poistion = "Associate Prof"
                  }        
                  );
        }
    }
}
