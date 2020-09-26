using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp4
{
    enum CategoryType {Technics=1,Products,Medicine,Cars,Clothes,Cosmetics,Accessories,Other };
    struct Product

    {
        public string Name { get; set; }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    value = 0;

                price = value;
            }
        }

        public readonly DateTime ManufactureDate ;
        public CategoryType Category { get; set; }
        public Product(string name, decimal price, CategoryType category, DateTime dt)
        {
            Name = name;
            this.price = price;
            Category = category;
            ManufactureDate = dt;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nCategory: {Category}\nPrice: {price}\nData of manufacture: { ManufactureDate}";
        }
    }

}
