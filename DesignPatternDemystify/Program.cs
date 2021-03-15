using System;

using Core;
using DependencyInjectionPatterns;
using ObserverPatterns;
using StrategyPatterns;

namespace DesignPatternDemystify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DESIGN PATTERNS DEMYSTIFIED !!!");
            IPattern pattern;
            
            pattern = new StrategyPattern();
            pattern.Implement();

            pattern = new DependencyInjection();
            pattern.Implement();

            pattern = new ObserverPattern();
            pattern.Implement();

            Console.ReadLine();

        }
    }
}
