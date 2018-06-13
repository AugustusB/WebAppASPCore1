using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppASPCore1.Home.ViewModel;
using WebAppASPCore1.Model;
using WebAppASPCore1.Services;

namespace WebAppASPCore1.Controllers
{
    public class HomeController : Controller
    {
        private IDeveloperData _developers;
        private ICompany _company;

        public HomeController(IDeveloperData developers,
            ICompany company)
        {
            _developers = developers;
            _company = company;
        }
        public IActionResult Index()
        {
            var model = _developers.GetDevelopers().Where(d => d.Id > 0);
            var vModel = new HomeIndexVM() { Developers = model, CompanyMessage = _company.GetMessageOfTheDay() };

            return View(vModel);
        }

        public IActionResult Details(int id)
        {
            var model = _developers.GetDevelopers().FirstOrDefault(d => d.Id == id);
            if (model == null)
                return RedirectToAction(nameof(Index));
            else
                return View(model);
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HomeDeveloperVM devVM)
        {
            if (ModelState.IsValid)
            { 
                var newDev = new Developer()
                {
                    Name = devVM.Name,
                    Age = devVM.Age,
                    TypeOfDev = devVM.TypeOfDev,
                    Address = devVM.Address
                };

                newDev = _developers.Add(newDev);

                return RedirectToAction(nameof(Details), new { id = newDev.Id });
            }
            else
            {
                return View();
            }
        }
    }
}