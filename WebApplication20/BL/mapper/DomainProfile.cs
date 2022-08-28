using AutoMapper;
using WebApplication20.BL.VM;
using WebApplication20.DAL.Entities;

namespace WebApplication20.BL.mapper
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<StudentVm, Student>();
            CreateMap<Student, StudentVm>();
            CreateMap<Course, CourseVM>();
            CreateMap<CourseVM, Course>();
            CreateMap<studentCourseVM, StudentCourse>();
            CreateMap<StudentCourse, studentCourseVM>();
        }
    }
}
