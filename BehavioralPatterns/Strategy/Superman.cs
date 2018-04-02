using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class Superman : Soldier, IRefillBehavior, IRepairBehavior
    {
        public Superman(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior)
            : base(weapon, refillBehavior, repairBehavior)
        {
            Console.WriteLine("I am superman");
        }
    }
}
