using System;
using Core;
using ObserverPatterns.Example1_WeatherBroadcasting.Observable;
using ObserverPatterns.Example1_WeatherBroadcasting.Observer;

namespace ObserverPatterns
{
    public class ObserverPattern:IPattern
    {
        public void Implement()
        {
            Console.WriteLine("\nLearning Observer Pattern\n");
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
