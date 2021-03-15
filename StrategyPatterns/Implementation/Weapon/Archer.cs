using System;
using StrategyPatterns.Interface;


namespace StrategyPatterns.Implementation.Weapon
{
    public class Archer : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Using bows to attack");
        }


    }
}
