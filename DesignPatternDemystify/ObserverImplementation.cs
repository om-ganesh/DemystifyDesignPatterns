using BehavioralPatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemystify
{
    public class ObserverImplementation
    {
        public ObserverImplementation()
        {
            WeatherData weatherData = new WeatherData(temperature: 40, pressure: 120, humidity: 20);
            Console.WriteLine(weatherData.ToString());
            IObserver sObserver = new StatisticsDisplay();
            weatherData.RegisterObserver(sObserver);
            IObserver fObserver = new ForecastDisplay();
            weatherData.RegisterObserver(fObserver);
            IObserver gObserver = new GeneralDisplay();
            weatherData.RegisterObserver(gObserver);
            weatherData.NotifyObserver();
            sObserver.Display();
            fObserver.Display();
            gObserver.Display();

            weatherData.DataChanged(temperature: 20, pressure: 80, humidity: 10);  //Just a dummy method which updates the weather data
            Console.WriteLine($"\nWeather changed {weatherData.ToString()}");
            sObserver.Display();
            fObserver.Display();
            gObserver.Display();

            Console.WriteLine("\nObserver Removed: General Display");
            weatherData.RemoveObserver(gObserver);
            weatherData.DataChanged(temperature: -20, pressure: 20, humidity: 0);  //Just a dummy method which updates the weather data
            sObserver.Display();
            fObserver.Display();
            gObserver.Display();

        }
    }
}
