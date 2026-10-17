using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intro_EF_A.Models
{
    [Table("students")]
    public class Student
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string department { get; set; }

        [Required(ErrorMessage = "CGPA is required")]
        public double cgpa { get; set; }
    }
}