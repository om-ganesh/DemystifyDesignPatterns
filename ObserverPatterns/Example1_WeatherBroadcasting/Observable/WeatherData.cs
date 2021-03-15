using System;
using System.Collections.Generic;

using ObserverPatterns.Example1_WeatherBroadcasting.Observer;

namespace ObserverPatterns.Example1_WeatherBroadcasting.Observable
{
    public class WeatherData : IObservable
    {
        private int Temperature;
        private int Pressure;
        private int Humidity;

        //Keep track of all the observers which need to be notifies whenever there is change in observable property
        List<IObserver> observers;

        public WeatherData(int temperature, int pressure, int humidity)
        {
            this.Temperature = temperature;
            this.Pressure = pressure;
            this.Humidity = humidity;

            if(observers == null)
            {
                observers = new List<IObserver>();
            }
        }

        //Stub method to just change the property for explanation
        public void DataChanged(int temperature, int pressure, int humidity)
        {
            this.Temperature = temperature;
            this.Pressure = pressure;
            this.Humidity = humidity;

            //Data has been changed so notify all the subscribers
            NotifyObserver();
        }

        public void RegisterObserver(IObserver observer)
        {
            if(observers.IndexOf(observer) == -1)
            {
                observers.Add(observer);
            }
        }

        /// <summary>
        /// This is the core method which notifies all of its observers
        /// </summary>
        public void NotifyObserver()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(Temperature, Pressure, Humidity);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.RemoveAt(observers.IndexOf(observer));
        }

        public override string ToString()
        {
            return $"Temperature: {this.Temperature}, Pressure: {this.Pressure}, Humidity: {this.Humidity}";
        }

    }
}
