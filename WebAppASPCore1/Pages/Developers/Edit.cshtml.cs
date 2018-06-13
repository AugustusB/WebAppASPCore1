using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppASPCore1.Model;
using WebAppASPCore1.Services;

namespace WebAppASPCore1.Pages.Developers
{
    public class EditModel : PageModel
    {
        private IDeveloperData _developerData;

        public EditModel(IDeveloperData devData)
        {
            _developerData = devData;
        }

        [BindProperty]
        public Developer Developer { get;  set; }

        public IActionResult OnGet(int Id)
        {
            Developer = _developerData.Get(Id);

            if (Developer == null)
                return RedirectToAction("Index", "Home");
            else
                return Page();

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Developer = _developerData.Update(Developer);
                return RedirectToAction("Details", "Home", new { id = Developer.Id });
            }
            return Page();
        }
    }
}