using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class Archerman : Soldier, IRefillBehavior, IRepairBehavior
    {
        public Archerman(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior) 
            :base(weapon,refillBehavior, repairBehavior)
        {
            Console.WriteLine("I am archerman");
        }

    }
}
