using System;

namespace DIPatterns.CommerceRepo
{
    internal class BillingProcessor
    {

        internal void ProcessPayment(object creditCard, object customerName)
        {
            Console.WriteLine($"Payment processed from {creditCard} !!!");
        }

    }
}