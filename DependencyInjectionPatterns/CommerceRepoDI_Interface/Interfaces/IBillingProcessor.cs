using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionPatterns.CommerceRepoDI_Interface.Interfaces
{
    interface IBillingProcessor
    {
        void ProcessPayment(string creditCard, string customerName);

    }
}
