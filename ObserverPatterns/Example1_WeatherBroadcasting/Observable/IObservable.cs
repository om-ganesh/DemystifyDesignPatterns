using System;

using ObserverPatterns.Example1_WeatherBroadcasting.Observer;

namespace ObserverPatterns.Example1_WeatherBroadcasting.Observable
{
    /// <summary>
    /// This interface can be observed
    /// Observable goes into changes
    /// 1:MANY dependency between objects so that when one observe, all of the dependents aer notified and updatated automatically
    /// </summary>
    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
