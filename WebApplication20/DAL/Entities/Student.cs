using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication20.DAL.Entities
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public string phone { get; set; }

        public string imgName { get; set; }


    }
}
