using Microsoft.Extensions.Configuration;

namespace WebAppASPCore1.Services
{
    public interface ICompany
    {
        string GetCompanyName();
        string GetMessageOfTheDay();
    }
}