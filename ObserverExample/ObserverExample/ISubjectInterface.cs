using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    public interface ISubjectInterface
    {
        public void RegisterObserver(IObserverInterface o);
        public void RemoveObserver(IObserverInterface o);
        public void NotifyObserver();
    }
}
