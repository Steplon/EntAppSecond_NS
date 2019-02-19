using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntAppSecond_NS.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond_NS.Pages.Students
{
    public class CreateModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public Student Student { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            Message = "Hello server, ";

            if (ModelState.IsValid)
            {
                Message += "all is well";
            }
            else
            {
                Message += "we are in trouble";
            }
        }
    }
}