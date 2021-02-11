using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenClose
{
    public class ProductFilter
    {
        public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var item in products)
            {
                if (item.color == color)
                    yield return item;
            }
        }

        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var item in products)
            {
                if (item.size == size)
                    yield return item;
            }
        }

        public static IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (var item in products)
            {
                if (item.color == color && item.size == size)
                    yield return item;
            }
        }
    }
}
