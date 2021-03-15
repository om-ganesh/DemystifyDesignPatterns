using System;
using System.Collections.Generic;
using System.Text;

using DependencyInjectionPatterns.DAO;

namespace DependencyInjectionPatterns.CommerceRepoDI_Interface.Interfaces
{
    interface INotifier
    {
        void SendReceipt(Product product);
    }
}
