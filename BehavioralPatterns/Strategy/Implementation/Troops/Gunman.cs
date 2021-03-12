using System;
using BehavioralPatterns.Strategy.Interface;


namespace BehavioralPatterns.Strategy.Implementation.Troops
{
    public class Gunman : Soldier
    {
        public Gunman(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior)
            : base(weapon,refillBehavior, repairBehavior)
        {
            this.hitPoints = 40;
            Console.WriteLine("Gunman created.");
        }

    }
}
