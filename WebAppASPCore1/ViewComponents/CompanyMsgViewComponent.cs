using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppASPCore1.Services;

namespace WebAppASPCore1.ViewComponents
{
    public class CompanyMsgViewComponent : ViewComponent
    {
        private ICompany _company;

        public CompanyMsgViewComponent(ICompany company)
        {
            _company = company; 
        }

        public IViewComponentResult Invoke()
        {
            var model = _company.GetMessageOfTheDay();
            return View("Default", model);
        }
    }
}
