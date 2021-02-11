using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.InterfaceSegregation
{
    public class Document
    {
        public string Name { get; set; }
        public Document()
        {
            this.Name = "";
        }
    }
    public interface IMachine
    {
        void Print(Document D);
        void Scan(Document D);
        void Fax(Document D);

    }


    public class MultiFunctionalMachine : IMachine
    {
        public void Fax(Document D)
        {
            Console.WriteLine("I can fax");
        }

        public void Print(Document D)
        {
            Console.WriteLine("I can print");
        }

        public void Scan(Document D)
        {
            Console.WriteLine("I can scan");
        }
    }

    // Issue: We have to inherit the features that our class doesn't support
    public class TraditionalPrinter : IMachine
    {
        public TraditionalPrinter()
        {
        }

        public void Fax(Document D)
        {
            throw new NotImplementedException();
        }

        public void Print(Document D)
        {
            Console.WriteLine("I can print");
        }

        public void Scan(Document D)
        {
            throw new NotImplementedException();
        }
    }
}
