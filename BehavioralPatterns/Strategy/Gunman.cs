using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class Gunman : Soldier, IRefillBehavior, IRepairBehavior
    {
        public Gunman(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior)
            : base(weapon,refillBehavior, repairBehavior)
        {
            Console.WriteLine("I am gunman");
        }

    }
}
