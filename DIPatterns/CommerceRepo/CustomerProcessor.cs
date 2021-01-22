using System;

using DIPatterns.DAO;
namespace DIPatterns.CommerceRepo
{
    internal class CustomerProcessor
    {
        internal void UpdateCustomerOrder(string customerName, Product product)
        {
            Console.WriteLine($"Customer {customerName}'s order updated!!!");
        }
    }
}