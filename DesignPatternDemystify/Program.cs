using System;

namespace DesignPatternDemystify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DESIGN PATTERNS DEMYSTIFIED !!!");

            Console.WriteLine("\n(I) Learning Strategy Pattern\n");
            new StrategyImplementation();

            Console.WriteLine("\n(II) Learning Observer Pattern\n");
            new ObserverImplementation();

            Console.WriteLine("\n(III) Learning Dependency Injection Pattern\n");
            new DIPatterns.Start();

            Console.ReadLine();

        }
    }
}
