using System;

namespace DependencyInjectionPatterns.CommerceRepo
{
    internal class BillingProcessor
    {

        internal void ProcessPayment(object creditCard, object customerName)
        {
            Console.WriteLine($"Payment processed from {creditCard} !!!");
        }

    }
}