using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication20.DAL.Entities

{
    public class Course
    {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }
        public string name { get; set; }
        public int hours { get; set; }

    }
}
