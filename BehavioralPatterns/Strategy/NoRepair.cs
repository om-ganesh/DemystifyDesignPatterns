using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class NoRepair : IRepairBehavior
    {
        public void Repair()
        {
            //Do nothing
        }
    }
}
