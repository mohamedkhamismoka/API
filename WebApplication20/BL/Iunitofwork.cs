using WebApplication20.BL.interfaces;
using WebApplication20.DAL.Entities;

namespace WebApplication20.BL
{
    public interface Iunitofwork
    {
       public IBaseRepository<Student> students { get; set; }
        public IBaseRepository<Course> courses { get; set; }
        public IBaseRepository<StudentCourse> studentcourses { get; set; }
    }
}
