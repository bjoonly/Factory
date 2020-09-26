using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    partial class Factory
    {

        public decimal AvgSalary
        {
            get
            {
                decimal avg = 0;
                for (int i = 0; i < employees.Length; i++)
                    avg += employees[i].Salary;
                return avg/employees.Length;

            }
        }

        public decimal TotalSalary {
            get{
                decimal sum = 0;
                for (int i = 0; i <employees.Length; i++)
                    sum += employees[i].Salary;
                return sum;
            }
        }

        public decimal GPD  {
            get{
                decimal sum = 0;
                for (int i = 0; i < products.Length; i++)
                    sum += products[i].Price;
                sum /= employees.Length;
                return sum;
            }
        }


        public int EmpCount {
            get { return employees.Length; }
        }

        public override string ToString()        {
            var line = new StringBuilder();
            line.Append($"Name:{Name}\n");
            for(int i = 0; i < employees.Length; i++)
            line.Append($"{i+1+"."+employees[i].ToString()}\n");
            
            for(int i = 0; i <products.Length; i++) 
                line.Append($"{i+1+ "."+products[i].ToString()}\n");
            
            return line.ToString();
        }
    } 
}

