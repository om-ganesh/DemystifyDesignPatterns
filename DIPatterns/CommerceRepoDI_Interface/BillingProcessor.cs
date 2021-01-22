using System;

using DIPatterns.CommerceRepoDI_Interface.Interfaces;

namespace DIPatterns.CommerceRepoDI_Interface
{
    public class BillingProcessor : IBillingProcessor
    {

        public void ProcessPayment(string creditCard, string customerName)
        {
            Console.WriteLine($"Payment processed from {creditCard} !!!");
        }


    }
}