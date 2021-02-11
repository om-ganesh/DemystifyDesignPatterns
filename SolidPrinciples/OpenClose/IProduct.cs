using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenClose
{
    // We can also create a template based specification 
    //public interface ISpecification<T>
    //{
    //    bool isSatisfied(T t);
    //}

    public interface IProductSpecification
    {
        bool isSatisfied(Product product);
    }

    public interface IFilter
    {
        IEnumerable<Product> Filter(IEnumerable<Product> product, IProductSpecification spec);
    }
}
