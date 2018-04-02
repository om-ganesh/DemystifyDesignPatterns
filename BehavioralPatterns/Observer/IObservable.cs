using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Observer
{
    /// <summary>
    /// This interface can be observed
    /// Observable goes into changes
    /// </summary>
    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
