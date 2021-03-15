using System;

using DependencyInjectionPatterns.CommerceRepoDI_Interface.Interfaces;
using DependencyInjectionPatterns.DAO;

namespace DependencyInjectionPatterns.CommerceRepoDI_Interface
{
    public class CustomerProcessor : ICustomerProcessor
    {
        public void UpdateCustomerOrder(string customerName, Product product)
        {
            Console.WriteLine($"Customer {customerName}'s order updated!!!");
        }
    }
}