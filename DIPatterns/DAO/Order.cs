using System;

namespace DIPatterns.DAO
{
    public class Order
    {
        public string CustomerName { get; set; }
        public string CreditCard { get; set; }
        public string Address { get; set; }
        public Product Product { get; set; }


        public Order() { }

        public Order(string customerName, string creditCard, string address, Product product)
        {
            this.CustomerName = customerName;
            this.CreditCard = creditCard;
            this.Address = address;
            this.Product = product;
        }
    }

}