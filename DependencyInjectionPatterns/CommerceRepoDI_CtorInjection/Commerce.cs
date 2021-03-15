using System;
using System.Collections.Generic;
using System.Text;

using DependencyInjectionPatterns.DAO;

namespace DependencyInjectionPatterns.CommerceRepoDI_CtorInjection
{
    class Commerce
    {
        BillingProcessor billingProcessor;
        CustomerProcessor customerProcessor;
        Notifier notifier;

        public Commerce()
        {

        }
        public Commerce(BillingProcessor billingProcessor, CustomerProcessor customerProcessor, Notifier notifier)
        {
            this.billingProcessor = billingProcessor;
            this.customerProcessor = customerProcessor;
            this.notifier = notifier;
        }

        public void ProcessOrder()
        {
            billingProcessor.ProcessPayment();
            customerProcessor.UpdateCustomerOrder();
            notifier.SendReceipt();
        }
    }
}
