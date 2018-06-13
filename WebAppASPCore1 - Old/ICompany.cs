using Microsoft.Extensions.Configuration;

namespace WebAppASPCore1
{
    public interface ICompany
    {
        string GetCompanyName();
    }

    public class MyComapny : ICompany
    {
        private IConfiguration _configuration;

        public MyComapny(IConfiguration config)
        {
            _configuration = config;
        }
        public string GetCompanyName()
        {
            return _configuration["MyHeader"] + " from ICompany servcie using appsetting.json";
            //return "AI SoftwareTech From ICompany";
        }
    }
}