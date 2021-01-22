using System;

using DIPatterns.CommerceRepoDI_Interface.Interfaces;
using DIPatterns.DAO;

namespace DIPatterns.CommerceRepoDI_Interface
{
    public class Notifier : INotifier
    {
        public void SendReceipt(Product product)
        {
            Console.WriteLine($"Email receipt sent for the order {product.Name} !!!");
        }
    }
}