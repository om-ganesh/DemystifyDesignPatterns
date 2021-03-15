using System;

using DependencyInjectionPatterns.CommerceRepoDI_Interface.Interfaces;

namespace DependencyInjectionPatterns.CommerceRepoDI_Interface
{
    public class BillingProcessor : IBillingProcessor
    {

        public void ProcessPayment(string creditCard, string customerName)
        {
            Console.WriteLine($"Payment processed from {creditCard} !!!");
        }


    }
}