using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond_NS.Pages
{
    public class FormWSModel : PageModel
    {

        [BindProperty]
        public string ProductCode { get; set; }

        [BindProperty]
        public string ColorSelected { get; set; }

        [BindProperty]
        public bool Consented { get; set; }



        public void OnGet()
        {

        }
    }
}