using System;
using BehavioralPatterns.Strategy.Interface;


namespace BehavioralPatterns.Strategy.Implementation.RefillType
{
    public class NoRefill : IRefillBehavior
    {
        public void Refill()
        {
            //Do nothing
        }
    }
}
