﻿using System;

using DependencyInjectionPatterns.DAO;

namespace DependencyInjectionPatterns.CommerceRepoDI_CtorInjection
{
    internal class Notifier
    {
        public Order order { get; set; }

        public Notifier()
        {

        }

        public Notifier(Order order)
        {
            this.order = order;
        }

        internal void SendReceipt()
        {
            Console.WriteLine($"Email receipt sent for the order {this.order.Product.Name} !!!");
        }
    }
}