﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntAppSecond_NS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntAppSecond_NS.Pages.Students
{
    public class CreateStudentModel : PageModel
    {
        private readonly CollegeContext _db;

        public CreateStudentModel(CollegeContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Student Student { get; set; } = new Student();


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(Student);
                await _db.SaveChangesAsync();
                return RedirectToPage("ListStudents");
            }
            else
            {
                return Page();
            }
        }

    }
}