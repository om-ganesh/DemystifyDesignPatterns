using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    /// <summary>
    /// Robot is special kind of Soaldier who can refill the weapons and also repairs itself (don't die)
    /// </summary>
    public class Robot : Soldier, IRefillBehavior, IRepairBehavior
    {
        public Robot(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior)
            : base(weapon, refillBehavior, repairBehavior)
        {
            Console.WriteLine("I am Robot");
        }
    }
}
