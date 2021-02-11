using SolidPrinciples.OpenClose;
using System;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //O of SOLID: OpenClose Principle
            //Traditional Technique
            new ProductImplementation().Execute();
            //OpenClose Illustration
            new ProductImplementation().ExecuteUsingOpenClosePrinciple();


            Console.Read();
        }
    }
}
