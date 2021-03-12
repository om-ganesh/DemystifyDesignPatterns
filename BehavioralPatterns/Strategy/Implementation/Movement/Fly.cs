using System;
using BehavioralPatterns.Strategy.Interface;


namespace BehavioralPatterns.Strategy.Implementation.Movement
{
    class Fly:IMovement
    {
        public void Move()
        {
            Console.WriteLine("I can Fly");
        }
    }
}
