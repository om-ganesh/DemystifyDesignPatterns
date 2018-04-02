using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Observer
{
    public class GeneralDisplay : IObserver
    {
        //This observer will only observe the temperature
        int Temperature;

        public void Display()
        {
            Console.WriteLine($"General display of the weather data {Temperature}");
        }

        //The only drawback is the observers will receive all the properties which they don't care about too
        public void Update(int temperature, int pressure, int humidity)
        {
            Temperature = temperature;
            Console.WriteLine($"General display window is updated");
        }
    }
}
