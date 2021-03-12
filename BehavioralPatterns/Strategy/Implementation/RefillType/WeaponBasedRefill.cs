using System;
using BehavioralPatterns.Strategy.Interface;


namespace BehavioralPatterns.Strategy.Implementation.RefillType
{
    public class WeaponBasedRefill : IRefillBehavior
    {
        public void Refill()
        {
            Console.WriteLine("Reloaded weapons based on count");
        }
    }
}
