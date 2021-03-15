using System;

namespace DependencyInjectionPatterns.DAO
{
    public class Product
    {
        public string Name { get; set; }

        public Product(string name)
        {
            this.Name = name;
        }
    }
}