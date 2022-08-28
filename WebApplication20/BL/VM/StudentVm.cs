using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WebApplication20.BL.VM
{
    public class StudentVm
    {
    
        public int id { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        [MinLength(3,ErrorMessage ="min length is 3")]
        [MaxLength(50, ErrorMessage = "max length is 50")]
        public string name { get; set; }
        [Required(ErrorMessage = "address is Required")]
        [MinLength(3, ErrorMessage = "min length is 3")]
        [MaxLength(50, ErrorMessage = "max length is 50")]
        public string address { get; set; }

        [Required(ErrorMessage = "phone is Required")]
        public string phone { get; set; }

        public string imgName { get; set; }
        public IFormFile img { get; set; }
    }
}
