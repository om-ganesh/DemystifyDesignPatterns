using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Observer
{
    /// <summary>
    /// This is the observers, which will be notified 
    /// </summary>
    public interface IObserver
    {
        void Update(int temperature, int pressure, int humidity);
        void Display();
    }
}
