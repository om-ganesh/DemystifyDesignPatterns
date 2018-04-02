using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class Paladin : Soldier, IRefillBehavior, IRepairBehavior
    {
        public Paladin(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior) 
            : base(weapon, refillBehavior, repairBehavior)
        {
            Console.WriteLine("I am a paladin");
        }
    }
}
