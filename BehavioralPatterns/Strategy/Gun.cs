using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class Gun : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Using pistols to attack");
        }

        
    }
}
