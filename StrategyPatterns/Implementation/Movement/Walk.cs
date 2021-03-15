using System;
using StrategyPatterns.Interface;

namespace StrategyPatterns.Implementation.Movement
{
    class Walk: IMovement
    {
        public void Move()
        {
            Console.WriteLine("I can Walk");
        }
    }
}
