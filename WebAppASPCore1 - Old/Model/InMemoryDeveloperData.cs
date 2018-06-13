using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppASPCore1.Services;

namespace WebAppASPCore1.Model
{
    public class InMemoryDeveloperData : IDeveloperData
    {
        private List<Developer> _developers;

        public InMemoryDeveloperData()
        {
            _developers = new List<Developer>()
            {
                new Developer{Id = 1, Name="Jank", Address="England", Age=19},
                new Developer{Id = 2, Name="Jank", Address="Walse", Age=29},
                new Developer{Id = 3, Name="Jank", Address="Scotland", Age=39}
            };
        }
        public IEnumerable<Developer> GetDevelopers()
        {
            foreach (var item in _developers)
            {
                yield return item;
            }
        }
    }
}
