using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppASPCore1.Model;

namespace WebAppASPCore1.Home.ViewModel
{
    public class HomeIndexVM
    {
        public IEnumerable<Developer> Developers { get; set; }
        public string CompanyMessage { get; set; }

    }
   
}
