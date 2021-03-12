using System;
using BehavioralPatterns.Strategy.Interface;


namespace BehavioralPatterns.Strategy.Implementation.RepairType
{
    public class SelfRepair : IRepairBehavior
    {
        public void Repair()
        {
            Console.WriteLine("I can repair myself");
        }
    }
}
