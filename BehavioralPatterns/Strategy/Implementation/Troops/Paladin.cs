using System;
using BehavioralPatterns.Strategy.Interface;


namespace BehavioralPatterns.Strategy.Implementation.Troops
{
    public class Paladin : Soldier
    {
        public Paladin(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior) 
            : base(weapon, refillBehavior, repairBehavior)
        {
            this.hitPoints = 80;
            Console.WriteLine("Paladin created.");
        }
    }
}
