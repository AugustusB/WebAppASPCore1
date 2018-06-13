using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppASPCore1.Services;

namespace WebAppASPCore1.Pages
{
    public class CompanyModel : PageModel
    {
        private ICompany _company;

        public CompanyModel(ICompany company)
        {
            _company = company;
        }

        public string CompanyMessageForTheDay { get; private set; }

        public void OnGet(string name)
        {
            CompanyMessageForTheDay = $"{name} : {_company.GetMessageOfTheDay()}";
        }
    }
}