using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenClose
{
    // Requirement1: Keep list of products and provide option to filter by color
    // Requirement2: Add the functionality to filter by size
    // Requirement3: Our customers are demanding, so lets provide option to filter by both color and size
    public class ProductImplementation
    {
        List<Product> products;
        public ProductImplementation()
        {
            products = new List<Product>();
            products.Add(new Product(Color.Red, Size.Small, "Apple"));
            products.Add(new Product(Color.Blue, Size.Small, "Block"));
            products.Add(new Product(Color.Green, Size.Large, "Tree"));
            products.Add(new Product(Color.Green, Size.Medium, "Painting"));
        }

        public void Execute()
        {
            Console.WriteLine("Traditional Implementation");
            Console.WriteLine("Filter by Color.Green");
            var gp = ProductFilter.FilterByColor(products, Color.Green);
            foreach(var item in gp)
            {
                Console.WriteLine(item.name);
            }

            Console.WriteLine("Filter by Size.Medium");
            var sp = ProductFilter.FilterBySize(products, Size.Medium);
            foreach (var item in sp)
            {
                Console.WriteLine(item.name);
            }
        }

        public void ExecuteUsingOpenClosePrinciple()
        {
            Console.WriteLine("Open Close Principle Implementation");
            Console.WriteLine("Filter by Color.Green");
            IProductSpecification colorSpec = new ColorSpecification(Color.Green);
            OCProductFilter pf = new OCProductFilter();
            var gp = pf.Filter(products, colorSpec);
            foreach (var item in gp)
            {
                Console.WriteLine(item.name);
            }

            Console.WriteLine("Filter by both color and size");
            IProductSpecification andSpec = new AndSpecification(colorSpec, new SizeSpecification(Size.Medium));
            OCProductFilter newPf = new OCProductFilter();
            var newGp = newPf.Filter(products, andSpec);
            foreach (var item in newGp)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
