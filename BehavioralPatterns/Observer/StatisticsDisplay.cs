using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Observer
{
    public class StatisticsDisplay : IObserver
    {
        private int Temperature;
        private int Humidity;

        public void Display()
        {
            Console.WriteLine($"Display of the current weather statistics {Temperature} and {Humidity}");
        }

        public void Update(int temperature, int pressure, int humidity)
        {
            Temperature = temperature;
            Humidity = humidity;
            Console.WriteLine($"Statistics Display is updated");
        }


    }
}
