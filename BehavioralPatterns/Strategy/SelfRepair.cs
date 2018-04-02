using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class SelfRepair : IRepairBehavior
    {
        public void Repair()
        {
            Console.WriteLine("I can repair myself");
        }
    }
}
