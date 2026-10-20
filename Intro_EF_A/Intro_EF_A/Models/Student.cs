using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intro_EF_A.Models
{

    public class AllowedDepartment: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string department = value.ToString().ToUpper();
                if (department != "CSE" && department != "EEE" && department != "BBA")
                {
                    return new ValidationResult(ErrorMessage ?? "Department should be in (CSE/EEE/BBA)");
                }
            } 
            return ValidationResult.Success;
        }
    }
    public class AllowedCgpa : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var cgpa = (double)value;

                if (cgpa < 0 || cgpa > 4)
                {
                    return new ValidationResult(ErrorMessage ?? "Cgpa must be greater than 0 and less than 4");
                }

            }
            return ValidationResult.Success;
        }
    }

    [Table("students")]
    public class Student
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [AllowedDepartment()]
        //[AllowedDepartment(ErrorMessage = "your custom error message")]
        public string department { get; set; }

        [Required(ErrorMessage = "CGPA is required")]
        [AllowedCgpa()]
        public double? cgpa { get; set; }
    }
} 