using WebAppASPCore1.Model;
using System.ComponentModel.DataAnnotations;

namespace WebAppASPCore1.Home.ViewModel
{
    public class HomeDeveloperVM
    {
        [Required, MaxLength(40)]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public eDeveloperType TypeOfDev { get; set; }
    }
}