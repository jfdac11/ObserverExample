using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    public class WeatherData : ISubjectInterface
    {
        private List<IObserverInterface> Observers;
        private float temperature;
        private float humidity;
        private float preassure;
        public WeatherData()
        {
            Observers = new List<IObserverInterface>();
        }

        public void NotifyObserver()
        {
            foreach(IObserverInterface ob in Observers)
            {
                ob.update(temperature, humidity, preassure);
            }
        }

        public void RegisterObserver(IObserverInterface o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(IObserverInterface o)
        {
            Observers.Remove(o);
        }
        public void MeasurementChanged()
        {
            NotifyObserver();
        }
        public void SetMeasurement(float temperature, float humidity, float preassure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.preassure = preassure;
            MeasurementChanged();

        }
    }
}
