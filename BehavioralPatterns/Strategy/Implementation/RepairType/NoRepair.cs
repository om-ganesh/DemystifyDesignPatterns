using System;
using BehavioralPatterns.Strategy.Interface;


namespace BehavioralPatterns.Strategy.Implementation.RepairType
{
    public class NoRepair : IRepairBehavior
    {
        public void Repair()
        {
            //Do nothing
        }
    }
}
