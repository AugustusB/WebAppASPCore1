using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppASPCore1.Model;

namespace WebAppASPCore1.Data
{
    public class DeveloperDBContext: DbContext 
    {
        public DeveloperDBContext(DbContextOptions options): 
            base (options)
        {}

        public DbSet<Developer> Developers { get; set; }
    }
}
