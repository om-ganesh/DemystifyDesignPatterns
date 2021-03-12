using BehavioralPatterns.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy.Implementation.Troops
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
