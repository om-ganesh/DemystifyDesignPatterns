using System;
using System.Collections.Generic;
using System.Text;

namespace DIPatterns.CommerceRepoDI_Interface.Interfaces
{
    interface IBillingProcessor
    {
        void ProcessPayment(string creditCard, string customerName);

    }
}
