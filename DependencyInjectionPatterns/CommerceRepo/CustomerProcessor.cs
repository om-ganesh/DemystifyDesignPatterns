using System;

using DependencyInjectionPatterns.DAO;
namespace DependencyInjectionPatterns.CommerceRepo
{
    internal class CustomerProcessor
    {
        internal void UpdateCustomerOrder(string customerName, Product product)
        {
            Console.WriteLine($"Customer {customerName}'s order updated!!!");
        }
    }
}