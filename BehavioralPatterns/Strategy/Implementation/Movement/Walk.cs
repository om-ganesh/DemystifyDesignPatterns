using System;
using BehavioralPatterns.Strategy.Interface;

namespace BehavioralPatterns.Strategy.Implementation.Movement
{
    class Walk: IMovement
    {
        public void Move()
        {
            Console.WriteLine("I can Walk");
        }
    }
}
