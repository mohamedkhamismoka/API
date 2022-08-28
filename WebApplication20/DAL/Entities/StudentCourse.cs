namespace WebApplication20.DAL.Entities
{
    public class StudentCourse
    {
        public int StudentId { get; set; }

        public int courseId { get; set; }

        public int degree { get; set; }

        public Student student { get; set; }

        public Course course { get; set; }

        public string grade { get; set; }
    }
}
