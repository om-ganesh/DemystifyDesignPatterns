using System;
using StrategyPatterns.Interface;


namespace StrategyPatterns.Implementation.RefillType
{
    public class TimeBasedRefill : IRefillBehavior
    {
        public void Refill()
        {
            Console.WriteLine("Automatically refilled on time basis");
        }
    }
}
