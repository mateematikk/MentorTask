using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorTask
{
    internal class Employee

    {
        public int company_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public DateTime employment_date { get; set; }
        public DateTime dismiss_date { get; set; }
        public decimal salary { get; set; }
        public Positions position { get; set; }

        public Employee(int company_id, string first_name, string last_name, string email, DateTime employment_date, decimal salary, Positions position)
        {
            this.company_id = company_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.salary = salary;
            this.employment_date = employment_date;
            this.position = position;

        }

    }

    enum Positions
    {
        developer,
        sales,
        manager,
        director
    }
}
