using System;
using BehavioralPatterns.Strategy.Interface;


namespace BehavioralPatterns.Strategy.Weapon
{
    public class Archer : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Using bows to attack");
        }


    }
}
