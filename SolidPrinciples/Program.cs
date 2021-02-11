using SolidPrinciples.OpenClose;
using System;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SOLID Principles!");

            //OOOOOOOOOOOOOOOOOOOOOOOOOO of SOLID
            //Traditional Technique
            new ProductImplementation().Execute();
            //OpenClose Illustration
            new ProductImplementation().ExecuteUsingOpenClosePrinciple();

            //IIIIIIIIIIIIIIIIIIIIIIIIII of SOLID
            //Traditional Technique
            new ProductImplementation().Execute();
            //OpenClose Illustration
            new ProductImplementation().ExecuteUsingOpenClosePrinciple();

            
            Console.Read();
        }
    }
}
