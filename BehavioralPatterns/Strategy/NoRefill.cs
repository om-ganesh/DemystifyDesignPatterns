using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class NoRefill : IRefillBehavior
    {
        public void Refill()
        {
            //Do nothing
        }
    }
}
