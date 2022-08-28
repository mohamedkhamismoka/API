using Microsoft.EntityFrameworkCore;
using WebApplication20.DAL.Entities;

namespace WebApplication20.DAL.Database
{
    public class database:DbContext
    {
        public database(DbContextOptions<database> opt):base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(a => new { a.StudentId, a.courseId });
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
          public DbSet<StudentCourse> studentCourses { get; set; }
    }
}
