using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    partial class Factory
    {
        private Employee[] employees;
        private Product[] products;
      public string Name { get; set; }


    

        public Factory(string name,Employee[]employees,Product[]products)
        {
            Name = name;
            this.employees = employees;
            this.products = products;
        }
    }


}
