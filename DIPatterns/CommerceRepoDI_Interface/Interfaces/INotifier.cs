using System;
using System.Collections.Generic;
using System.Text;

using DIPatterns.DAO;

namespace DIPatterns.CommerceRepoDI_Interface.Interfaces
{
    interface INotifier
    {
        void SendReceipt(Product product);
    }
}
