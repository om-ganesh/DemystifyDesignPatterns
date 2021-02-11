using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenClose
{
    public class ColorSpecification : IProductSpecification
    {
        Color color;
        public ColorSpecification(Color c)
        {
            this.color = c;
        }
        public bool isSatisfied(Product p)
        {
            return p.color == color;
        }
    }

    public class SizeSpecification : IProductSpecification
    {
        Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public bool isSatisfied(Product p)
        {
            return p.size == size;
        }
    }

    public class AndSpecification : IProductSpecification
    {
        IProductSpecification spec1, spec2;
        public AndSpecification(IProductSpecification spec1, IProductSpecification spec2)
        {
            this.spec1 = spec1;
            this.spec2 = spec2;
        }

        public bool isSatisfied(Product p)
        {
            return spec1.isSatisfied(p) && spec2.isSatisfied(p);
        }
    }

    public class OCProductFilter : IFilter
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, IProductSpecification specification)
        {
            foreach(var item in products)
            {
                if(specification.isSatisfied(item))
                {
                    yield return item;
                }
            }
        }
    }
}
