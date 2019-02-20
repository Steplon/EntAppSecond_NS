using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond_NS.Model
{
    public class Student
    {

        [Required]
        [RegularExpression(@"(S|s)/d{7}")]
        [Display(Name = "Student ID")]
        public string StudentID { get; set; } = "";


        [Required]
        [MinLength(2, ErrorMessage = "Min 2 characters in your first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";

        [Required]
        [MinLength(3, ErrorMessage = "Min 3 characters in your last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = "";

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "DOB")]
        public DateTime DOB { get; set; }

        [Required]
        [Range(2,int.MaxValue)]
        [Display(Name = "Number of Modules")]
        public int NumModules { get; set; }

        [Required]
        [Range(65,250)]
        [Display(Name = "Height")]
        public int Height { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Compare("Email", ErrorMessage = "The email addresses do not match.")]
        [Display(Name = "Email confirm")]
        public string EmailConfirm { get; set; }

    }
}
