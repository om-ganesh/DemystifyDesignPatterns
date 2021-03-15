using System;
using StrategyPatterns.Interface;


namespace StrategyPatterns.Implementation.RefillType
{
    public class WeaponBasedRefill : IRefillBehavior
    {
        public void Refill()
        {
            Console.WriteLine("Reloaded weapons based on count");
        }
    }
}
