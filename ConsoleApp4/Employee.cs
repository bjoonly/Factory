using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Employee {
        public string Name { get; set; }
        public string Surname { get; set; }

        private decimal salary;
        DateTime BirthDate { get; }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                     value=0;
                salary = value;
            }
        }


        public Employee(string name,string surname, decimal salary,DateTime bd)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            BirthDate = bd;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nSurname:{Surname}\nSalary: {salary}\nBirth date: {BirthDate}";
        }
    }
}

