using System;
using System.Linq;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
          /*Peter=11;George=4
            Bread=10;Milk=2
            Peter Bread
            George Milk
            George Milk
            Peter Milk
            END*/
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            string[] input = Console.ReadLine().Split(";");
            string[] input2 = Console.ReadLine().Split(";");
            //bool count = true;
            //int count1 = 0;

            foreach (var info in input)
            {
                string[] of = info.Split("=");
                Person person = new Person(of[0], int.Parse(of[1]));
                people.Add(person);
            }

            foreach (var info in input2)
            {
                string[] of = info.Split("=");
                Product product = new Product(of[0], int.Parse(of[1]));
                products.Add(product);
            }

            Dictionary<string, List<string>> dic_list = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input3 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input3[0] == "END")
                {
                    break;
                }
                Person current = new Person();
                Product current2 = new Product();
               // Person person1;
               //Product product;
               // person1 = people.FirstOrDefault();
                foreach (var person in people)
                {
                    if (person.Name == input3[0])
                    {
                        current = person;
                        break;
                    }
                }

                /*if (Char.IsDigit(input3[1][0])) // da raboti s 2 Bread/Milk
                {

                    foreach (var product in products)
                    {
                        if (product.Name == input3[2])
                        {
                            current2 = product;
                            break;
                        }
                    }
                    count = false;
                    count1 = int.Parse(input3[1]);
                }
                else
                {*/
                    foreach (var product in products)
                    {
                        if (product.Name == input3[1])
                        {
                            current2 = product;
                            break;
                        }
                    }
               // }

                //if (count)
                //{
                    NewMethod(dic_list, current, current2);
                //}
                /*else
                {
                    for (int i = 0; i < count1; i++)
                    {
                        NewMethod(dic_list, current, current2);
                    }
                    count = true;
                    count1 = 0;
                }*/
            }

            foreach (var info in dic_list)
            {
                Console.WriteLine($"{info.Key} - {String.Join(", ", info.Value)}");
            }
        }

        private static void NewMethod(Dictionary<string, List<string>> dic_list, Person current, Product current2)
        {
            if (current.Add(current2, current))
            {
                if (current.ProductList.Contains(current2))
                {
                    if (!dic_list.ContainsKey(current.Name))
                    {
                        dic_list.Add(current.Name, new List<string>());
                    }
                    dic_list[current.Name].Add(current2.Name);
                }
            }
        }
    }
}
