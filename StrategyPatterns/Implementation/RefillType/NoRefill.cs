using System;
using StrategyPatterns.Interface;


namespace StrategyPatterns.Implementation.RefillType
{
    public class NoRefill : IRefillBehavior
    {
        public void Refill()
        {
            //Do nothing
        }
    }
}
