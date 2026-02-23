using System.Data.Entity;

namespace ASPSchoolZlatomir.Models
{
    public class SchoolDbContext : DbContext

    {
         public SchoolDbContext() : base("SchoolDbContext12d2026")
        { 

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
       
    }
}
