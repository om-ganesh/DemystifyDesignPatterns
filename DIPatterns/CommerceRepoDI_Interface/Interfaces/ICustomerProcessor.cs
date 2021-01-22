using System;
using System.Collections.Generic;
using System.Text;

using DIPatterns.DAO;

namespace DIPatterns.CommerceRepoDI_Interface.Interfaces
{
    interface ICustomerProcessor
    {
        void UpdateCustomerOrder(string customerName, Product product);
    }
}
