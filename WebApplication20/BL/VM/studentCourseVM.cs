using System.ComponentModel.DataAnnotations;
using WebApplication20.DAL.Entities;

namespace WebApplication20.BL.VM
{
    public class studentCourseVM
    {
        [Required(ErrorMessage = "student is Required")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "course is Required")]
        public int courseId { get; set; }

        [Required(ErrorMessage = "degree is Required")]
   
        [Range(0, 100, ErrorMessage = "Range must be between 0  and 100")]
        public int degree { get; set; }

        public Student student { get; set; }

        public Course course { get; set; }

        public string grade { get; set; }
    }
}
