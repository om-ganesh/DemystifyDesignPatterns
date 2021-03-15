using System;
using System.ComponentModel;
using Autofac;
using Core;
using DependencyInjectionPatterns.CommerceRepo;
using DependencyInjectionPatterns.DAO;
using IContainer = Autofac.IContainer;

namespace DependencyInjectionPatterns
{
    public class DependencyInjection : IPattern
    {
        public static IContainer container;
        public void Implement()
        {
            Console.WriteLine("\nLearning Dependency Injection Pattern\n");
            // First Implementation (without using DI)
            Commerce commerce = new Commerce();
            Order o = new Order("Subash", "12245", "GWP", new Product("Dell"));
            commerce.ProcessOrder(o);


            // Second implementation of DI (using Constructor Injection)
            Product product = new Product("Dell");
            Order order = new Order("Subash", "12345", "GWP", product);
            CommerceRepoDI_CtorInjection.BillingProcessor billingProcessor = new CommerceRepoDI_CtorInjection.BillingProcessor(order.CreditCard, order.CustomerName);
            CommerceRepoDI_CtorInjection.CustomerProcessor customerProcessor = new CommerceRepoDI_CtorInjection.CustomerProcessor(order.CustomerName, product);
            CommerceRepoDI_CtorInjection.Notifier notifier = new CommerceRepoDI_CtorInjection.Notifier(order);

            CommerceRepoDI_CtorInjection.Commerce commerceDI = new CommerceRepoDI_CtorInjection.Commerce(billingProcessor, customerProcessor, notifier);
            commerceDI.ProcessOrder();


            // Third implementation of DI (using DI Container eg. Autofactory ) concept R&R (Registry and Resolver)
            ContainerBuilder builder = new ContainerBuilder();
            //Register commerce class and it now doesn't have any interface association
            builder.RegisterType<CommerceRepoDI_Interface.Commerce>();
            //Register Notifier class and attach to INotifier
            builder.RegisterType<CommerceRepoDI_Interface.Notifier>().As<CommerceRepoDI_Interface.Interfaces.INotifier>();
            builder.RegisterType<CommerceRepoDI_Interface.BillingProcessor>().As<CommerceRepoDI_Interface.Interfaces.IBillingProcessor>();
            builder.RegisterType<CommerceRepoDI_Interface.CustomerProcessor>().As<CommerceRepoDI_Interface.Interfaces.ICustomerProcessor>();
            container = builder.Build();

            Product product1 = new Product("Dell");
            Order order1 = new Order("Subash", "12345", "GWP", product1);
            CommerceRepoDI_Interface.Commerce commerce1 = container.Resolve<CommerceRepoDI_Interface.Commerce>();
            commerce1.ProcessOrder(order1);
            //CommerceRepoDI_Interface.BillingProcessor billingProcessor1 = container.Resolve<CommerceRepoDI_Interface.BillingProcessor(order1.CreditCard, order1.CustomerName);
            //CommerceRepoDI_Interface.CustomerProcessor customerProcessor1 = new CommerceRepoDI_Interface.CustomerProcessor(order1.CustomerName, product1);
            //CommerceRepoDI_Interface.Notifier notifier1 = new CommerceRepoDI_Interface.Notifier(order1);

            //CommerceRepoDI_Interface.Commerce commerceDI1 = new CommerceRepoDI_Interface.Commerce(billingProcessor1, customerProcessor1, notifier1);
            //commerceDI.ProcessOrder();
        }
    }
}
