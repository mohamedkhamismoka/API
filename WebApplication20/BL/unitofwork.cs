using WebApplication20.BL.interfaces;
using WebApplication20.BL.Reposatories;
using WebApplication20.DAL.Database;
using WebApplication20.DAL.Entities;

namespace WebApplication20.BL
{
    public class unitofwork:Iunitofwork
    {
        private readonly database db;

        public IBaseRepository<Student> students { get; set; }
        public IBaseRepository<Course> courses { get; set; }
        public IBaseRepository<StudentCourse> studentcourses { get; set; }

        public unitofwork(database db )
        {
            this.db = db;
            students=new BaseReposatory<Student>(db);
            courses = new BaseReposatory<Course>(db);
            studentcourses = new BaseReposatory<StudentCourse>(db);
        }
    }
}
