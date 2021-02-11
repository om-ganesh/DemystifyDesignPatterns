using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.InterfaceSegregation
{
    public interface IPrinter
    {
        void Print(Document D);
    }

    public interface IScanner
    {
        void Scan(Document D);
    }

    public interface IFax
    {
        void Fax(Document D);
    }


    public class TraditionalNewPrinter : IPrinter
    {
        public void Print(Document D)
        {
            Console.WriteLine("I can print");
        }
    }


    //Approach1
    public class MultiFunctionalNewMachine : IPrinter, IScanner, IFax
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


    //Approach2
    public interface IMultiFunctionalMachine: IPrinter, IScanner, IFax //...
    {
    }
    public class MultiFunctionalNewMachine2 : IMultiFunctionalMachine
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

}
