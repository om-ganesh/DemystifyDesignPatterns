using System;
using BehavioralPatterns.Strategy.Interface;


namespace BehavioralPatterns.Strategy.Implementation.RepairType
{
    public class ManualRepair : IRepairBehavior
    {
        public void Repair()
        {
            Console.WriteLine("I will require human to repair");
        }
    }
}
