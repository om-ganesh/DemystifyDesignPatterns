using System;

using DIPatterns.DAO;

namespace DIPatterns.CommerceRepo
{
    internal class Notifier
    {
        internal void SendReceipt(Product product)
        {
            Console.WriteLine($"Email receipt sent for the order {product.Name} !!!");
        }
    }
}