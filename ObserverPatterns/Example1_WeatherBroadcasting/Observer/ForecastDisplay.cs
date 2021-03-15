using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatterns.Example1_WeatherBroadcasting.Observer
{
    public class ForecastDisplay : IObserver
    {
        // This object cares about all the properties
        private int Temperature;
        private int Pressure;
        private int Humidity;
        public void Display()
        {
            Console.WriteLine($"Display of the tomorrow  forecast: {Temperature}, {Pressure} and {Humidity}");
        }

        public void Update(int temperature, int pressure, int humidity)
        {
            Temperature = temperature;
            Pressure = pressure;
            Humidity = humidity;
            Console.WriteLine($"Forecast is updated");
        }
    }
}
