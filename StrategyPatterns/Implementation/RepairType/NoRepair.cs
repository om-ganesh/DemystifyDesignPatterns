using System;
using StrategyPatterns.Interface;


namespace StrategyPatterns.Implementation.RepairType
{
    public class NoRepair : IRepairBehavior
    {
        public void Repair()
        {
            //Do nothing
        }
    }
}
