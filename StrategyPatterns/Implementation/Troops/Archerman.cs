
using System;
using StrategyPatterns.Interface;

namespace StrategyPatterns.Implementation.Troops
{
    public class Archerman : Soldier
    {
        public Archerman(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior) 
            :base(weapon,refillBehavior, repairBehavior)
        {
            this.hitPoints = 20;
            Console.WriteLine("Archerman created.");
        }

    }
}
