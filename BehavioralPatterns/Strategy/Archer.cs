using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class Archer : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Using bows to attack");
        }


    }
}
