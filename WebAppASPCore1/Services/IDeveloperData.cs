using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppASPCore1.Model;

namespace WebAppASPCore1.Services
{
    public interface IDeveloperData
    {
        IEnumerable<Developer> GetDevelopers();
        Developer Add(Developer newDev);
        Developer Get(int id);
        Developer Update(Developer developer);
    }
}
