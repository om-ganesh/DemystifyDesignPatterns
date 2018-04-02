using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class ManualRepair : IRepairBehavior
    {
        public void Repair()
        {
            Console.WriteLine("I will require human to repair");
        }
    }
}
