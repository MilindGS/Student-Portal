

using Microsoft.EntityFrameworkCore;
using StudentPortal.Controllers;

namespace StudentPortal.Models
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {

        }

        
        public virtual DbSet<Student> Students{ get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                // Enter connection string below
                optionsBuilder.UseSqlServer("");
            }
        }

        public static implicit operator StudentDbContext(StudentController v)
        {
            throw new NotImplementedException();
        }
    }
}
