using System;
using DependencyInjectionPatterns.DAO;

namespace DependencyInjectionPatterns.CommerceRepoDI_CtorInjection
{
    internal class CustomerProcessor
    {
        public string customerName { get; set; }
        public Product product { get; set; }

        public CustomerProcessor()
        {

        }

        public CustomerProcessor(string customerName, Product product)
        {
            this.customerName = customerName;
            this.product = product;
        }

        public void UpdateCustomerOrder()
        {
            Console.WriteLine($"Customer {this.customerName}'s order updated!!!");
        }
    }
}