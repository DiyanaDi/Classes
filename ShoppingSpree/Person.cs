using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {

        private string name;

        private int money;

        public List<Product> ProductList{get;set;}
        /*Create a program where each command corresponds to a person buying a product. If the person can afford a
product, add it to his bag. If a person doesn’t have enough money, print an appropriate message ({personName}
can't afford {productName}.*/

        public Person()
        {
            ProductList = new List<Product>();
        }
        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            ProductList = new List<Product>();
        }
            public bool Add(Product product, Person person)
        {
            if (product.Cost > person.Money)
            {
                Console.WriteLine($"{person.Name} can't afford {product.Name}.");
                return false;
            }
            else
            {
                person.Money -= product.Cost;
                person.ProductList.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
                return true;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty");
                }
                name = value;
            }
        }
            public int Money
        {
            get => money;
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Money cannot be negative");
                }
                money = value;
            }
        }
    }
}
