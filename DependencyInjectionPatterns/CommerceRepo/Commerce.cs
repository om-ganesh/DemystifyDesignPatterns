using System;
using System.Collections.Generic;
using System.Text;

using DependencyInjectionPatterns.DAO;

namespace DependencyInjectionPatterns.CommerceRepo
{
    class Commerce
    {
        public void ProcessOrder(Order order)
        {
            BillingProcessor billingProcessor = new BillingProcessor();
            billingProcessor.ProcessPayment(order.CreditCard, order.CustomerName);

            CustomerProcessor customerProcessor = new CustomerProcessor();
            customerProcessor.UpdateCustomerOrder(order.CustomerName, order.Product);

            Notifier notifier = new Notifier();
            notifier.SendReceipt(order.Product);
        }
    }
}
