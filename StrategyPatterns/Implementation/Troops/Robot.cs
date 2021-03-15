using System;
using StrategyPatterns.Interface;


namespace StrategyPatterns.Implementation.Troops
{
    /// <summary>
    /// Robot is special kind of Soaldier who can refill the weapons and also repairs itself (don't die)
    /// </summary>
    public class Robot : Soldier
    {
        public Robot(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior)
            : base(weapon, refillBehavior, repairBehavior)
        {
            this.hitPoints = 150;
            Console.WriteLine("Robot created.");
        }
    }
}
