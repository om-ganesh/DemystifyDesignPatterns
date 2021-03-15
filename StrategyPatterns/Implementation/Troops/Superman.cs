using System;
using StrategyPatterns.Interface;


namespace StrategyPatterns.Implementation.Troops
{
    public class Superman : Soldier
    {
        public Superman(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior)
            : base(weapon, refillBehavior, repairBehavior)
        {
            this.hitPoints = 100;
            Console.WriteLine("Superman created.");
        }
    }
}
