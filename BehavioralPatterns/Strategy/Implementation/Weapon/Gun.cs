using System;
using BehavioralPatterns.Strategy.Interface;

namespace BehavioralPatterns.Strategy.Weapon
{
    public class Gun : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Using pistols to attack");
        }

        
    }
}
