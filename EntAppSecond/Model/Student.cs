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

        [BindProperty]
        [RegularExpression(@"(S|s)/d{8}")]
        [Display(Name = "Student ID")]
        public string StudentID { get; set; } = "";


        [BindProperty]
        [StringLength(20, ErrorMessage = "Too many characters in your first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";



        [BindProperty]
        [StringLength(20, ErrorMessage = "Too many characters in your last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = "";



    }
}
