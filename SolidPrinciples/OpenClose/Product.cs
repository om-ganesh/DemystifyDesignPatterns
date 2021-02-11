using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenClose
{
    
    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public class Product
    {
        public Color color { get; set; }
        public Size size { get; set; }
        public string name { get; set; }
        public static int Count { get; set; }
        public Product(Color c, Size s, string n)
        {
            if(string.IsNullOrWhiteSpace(n))
            {
                throw new ArgumentNullException($"Product name can't be null.");
            }
            this.color = c;
            this.size = s;
            this.name = $"{++Count} - {n}";
        }
    }
}
