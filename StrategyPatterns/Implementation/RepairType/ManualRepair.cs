using System;
using StrategyPatterns.Interface;


namespace StrategyPatterns.Implementation.RepairType
{
    public class ManualRepair : IRepairBehavior
    {
        public void Repair()
        {
            Console.WriteLine("I will require human to repair");
        }
    }
}
