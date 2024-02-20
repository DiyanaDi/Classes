using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;

        private int cost;

        public Product()
        {

        }
        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
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
        public int Cost
        {
            get => cost;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                }
                cost = value;
            }
        }
    }
}
