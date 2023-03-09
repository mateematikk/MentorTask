using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorTask
{
    internal class Company
    {
        public int id {get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public decimal monthly_budget { get; set; }
        public Employee director { get; set; }
        public DateTime registration_date { get; set; }

        public List<Employee> employees { get; set; }

        public Company(string name, string brand, decimal monthly_budget, Employee director, DateTime registration_date)
        {
            this.name = name;
            this.brand = brand;
            this.monthly_budget = monthly_budget;
            this.director = director;
            this.registration_date = registration_date;
            this.employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

    }
}
