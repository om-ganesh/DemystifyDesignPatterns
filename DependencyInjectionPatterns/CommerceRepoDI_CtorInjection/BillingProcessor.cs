using System;

namespace DependencyInjectionPatterns.CommerceRepoDI_CtorInjection
{
    internal class BillingProcessor
    {
        public string creditCard { get; set; }
        public string customerName { get; set; }

        public BillingProcessor()
        {

        }
        public BillingProcessor(string creditCard, string customerName)
        {
            this.creditCard = creditCard;
            this.customerName = customerName;
        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Payment processed from {this.creditCard} !!!");
        }

    }
}