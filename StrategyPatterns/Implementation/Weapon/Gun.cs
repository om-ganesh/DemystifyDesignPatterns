using System;
using StrategyPatterns.Interface;

namespace StrategyPatterns.Implementation.Weapon
{
    public class Gun : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Using pistols to attack");
        }

        
    }
}
