using MentorTask;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Company> companies= new List<Company>();
        companies.Add(CreateCompany())
    }   

    public Company CreateCompany(string name, string brand, decimal monthly_budget, DateTime registration_date)
    {
        Employee director = new Employee();
        Company company = new Company(name, brand, monthly_budget, director, registration_date);
        return company;
    }

    public void AddEmployee(Employee employee, Company company)
    {

    }
}