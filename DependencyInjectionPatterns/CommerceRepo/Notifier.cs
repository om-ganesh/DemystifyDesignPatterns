using System;

using DependencyInjectionPatterns.DAO;

namespace DependencyInjectionPatterns.CommerceRepo
{
    internal class Notifier
    {
        internal void SendReceipt(Product product)
        {
            Console.WriteLine($"Email receipt sent for the order {product.Name} !!!");
        }
    }
}