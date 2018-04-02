using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class WeaponBasedRefill : IRefillBehavior
    {
        public void Refill()
        {
            Console.WriteLine("Reloaded weapons based on count");
        }
    }
}
