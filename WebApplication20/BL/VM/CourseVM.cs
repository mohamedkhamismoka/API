using System.ComponentModel.DataAnnotations;

namespace WebApplication20.BL.VM
{
    public class CourseVM
    {
   public int id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MinLength(3, ErrorMessage = "min length is 3")]
        [MaxLength(50, ErrorMessage = "max length is 50")]
        public string name { get; set; }

        [Required(ErrorMessage = "hours is Required")]
      [Range(1,3,ErrorMessage ="Range must be between 1  and 3")]
        public int hours { get; set; }
    }
}
