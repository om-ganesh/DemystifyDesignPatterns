using System;

using DependencyInjectionPatterns.CommerceRepoDI_Interface.Interfaces;
using DependencyInjectionPatterns.DAO;

namespace DependencyInjectionPatterns.CommerceRepoDI_Interface
{
    public class Notifier : INotifier
    {
        public void SendReceipt(Product product)
        {
            Console.WriteLine($"Email receipt sent for the order {product.Name} !!!");
        }
    }
}