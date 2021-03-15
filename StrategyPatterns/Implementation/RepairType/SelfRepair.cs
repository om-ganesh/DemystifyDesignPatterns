using System;
using StrategyPatterns.Interface;


namespace StrategyPatterns.Implementation.RepairType
{
    public class SelfRepair : IRepairBehavior
    {
        public void Repair()
        {
            Console.WriteLine("I can repair myself");
        }
    }
}
