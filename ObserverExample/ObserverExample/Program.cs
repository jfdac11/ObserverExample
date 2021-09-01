using System;

namespace ObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd= new WeatherData();
            //wd.SetMeasurement(8.23f, 89.98f, 56.6f);
            
            IObserverInterface display = new CurrentConditionsDisplay(wd);
            display.update(8.23f, 89.98f, 56.6f);
            
            
        }
    }
}
