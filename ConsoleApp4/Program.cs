using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

   
    class Program{

        static void Main(string[] args) {
            int sizeP = 0, sizeE = 0;
            Employee[] employees;
            Product[] products;
            Factory factory;
            string name, surname;
            decimal num;
            int index;
            DateTime dt;
            CategoryType ct;
            try {
                do
                {
                    Console.WriteLine("Enter the number of employees:");
                    sizeE = int.Parse(Console.ReadLine());
                    if (sizeE < 1)
                        Console.WriteLine("Ivalid number(<1)");
                } while (sizeE < 1);
                employees = new Employee[sizeE];
                for (int i = 0; i < sizeE; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Enter name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter surname:");
                    surname = Console.ReadLine();
                    Console.WriteLine("Enter birth date:");
                    dt = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter salary:");
                    num = decimal.Parse(Console.ReadLine());
                    employees[i] = new Employee(name, surname, num, dt);
                }

                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter the number of products:");
                    sizeP = int.Parse(Console.ReadLine());
                    if (sizeP < 1)
                        Console.WriteLine("Ivalid number(<1)");
                } while (sizeP < 1);
                products = new Product[sizeP];
                for (int i = 0; i < sizeP; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Enter name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter manufacture date:");
                    dt = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter price:");
                    num = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Enter category type:\n1.Technics\n2.Products\n3.Medicine\n4.Cars\n5.Clothes\n6.Cosmetics\n7.Accessories\n8.Other");
                    index = int.Parse(Console.ReadLine());
                    ct = CategoryType.Other;
                    if (index > 0 && index < 9)
                    {
                        switch (index)
                        {
                            case 1:
                                ct = CategoryType.Technics;
                                break;
                            case 2:
                                ct = CategoryType.Products;
                                break;
                            case 3:
                                ct = CategoryType.Medicine;
                                break;
                            case 4:
                                ct = CategoryType.Cars;
                                break;
                            case 5:
                                ct = CategoryType.Clothes;
                                break;
                            case 6:
                                ct = CategoryType.Cosmetics;
                                break;
                            case 7:
                                ct = CategoryType.Accessories;
                                break;
                            case 8:
                                ct = CategoryType.Other;
                                break;
                        }
                    }
                    products[i] = new Product(name, num, ct, dt);
                }
                Console.Clear();
                Console.WriteLine("Enter factory name:");
                name = Console.ReadLine();
                factory = new Factory(name, employees, products);
                Console.Clear();
                Console.WriteLine(factory.ToString());
                Console.WriteLine("Employees count: "+factory.EmpCount);
                Console.WriteLine("Average salary: "+factory.AvgSalary);
                Console.WriteLine("GDP: "+factory.GPD);
                Console.WriteLine("Total salary: "+factory.TotalSalary);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
            }

    }

}
