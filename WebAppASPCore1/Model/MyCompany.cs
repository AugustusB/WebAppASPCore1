using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppASPCore1.Services;

namespace WebAppASPCore1.Model
{
    public class MyCompany : ICompany
    {
        private IConfiguration _configuration;

        public MyCompany(IConfiguration config)
        {
            _configuration = config;
        }
        public string GetCompanyName() => _configuration["MyHeader"] + " from ICompany servcie using appsetting.json";//return "AI SoftwareTech From ICompany";
        public string GetMessageOfTheDay() => _configuration["MessageOfTheDay"];
    }
}
