using System;
using StrategyPatterns.Interface;


namespace StrategyPatterns.Implementation.Movement
{
    class Fly:IMovement
    {
        public void Move()
        {
            Console.WriteLine("I can Fly");
        }
    }
}
