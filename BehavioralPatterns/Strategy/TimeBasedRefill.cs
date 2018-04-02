using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class TimeBasedRefill : IRefillBehavior
    {
        public void Refill()
        {
            Console.WriteLine("Automatically refilled on time basis");
        }
    }
}
