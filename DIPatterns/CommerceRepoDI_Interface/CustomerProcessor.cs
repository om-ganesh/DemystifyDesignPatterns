using System;

using DIPatterns.CommerceRepoDI_Interface.Interfaces;
using DIPatterns.DAO;

namespace DIPatterns.CommerceRepoDI_Interface
{
    public class CustomerProcessor : ICustomerProcessor
    {
        public void UpdateCustomerOrder(string customerName, Product product)
        {
            Console.WriteLine($"Customer {customerName}'s order updated!!!");
        }
    }
}