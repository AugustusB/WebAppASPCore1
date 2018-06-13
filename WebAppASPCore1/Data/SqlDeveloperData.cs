using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppASPCore1.Model;
using WebAppASPCore1.Services;

namespace WebAppASPCore1.Data
{
    public class SqlDeveloperData : IDeveloperData
    {
        private DeveloperDBContext _context;

        public SqlDeveloperData(DeveloperDBContext context)
        {
            _context = context;
        }
        public Developer Add(Developer newDev)
        {
            _context.Developers.Add(newDev);
            _context.SaveChanges();
            return newDev;
        }

        public Developer Get(int id)
        {
            return _context.Developers.FirstOrDefault(d=> d.Id == id);
        }

        public IEnumerable<Developer> GetDevelopers()
        {
            return _context.Developers.OrderBy(d => d.Name);
        }

        public Developer Update(Developer developer)
        {
            _context.Attach(developer).State = EntityState.Modified;
            _context.SaveChanges();
            return developer;
        }
    }
}
