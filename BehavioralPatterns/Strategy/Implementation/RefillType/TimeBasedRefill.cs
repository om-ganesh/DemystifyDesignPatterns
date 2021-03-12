using System;
using BehavioralPatterns.Strategy.Interface;


namespace BehavioralPatterns.Strategy.Implementation.RefillType
{
    public class TimeBasedRefill : IRefillBehavior
    {
        public void Refill()
        {
            Console.WriteLine("Automatically refilled on time basis");
        }
    }
}
