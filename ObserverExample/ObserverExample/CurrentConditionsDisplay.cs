using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    public class CurrentConditionsDisplay : IObserverInterface, IDisplayElementInterface
    {
        private float Temperature;
        private float Humidity;
        private float Preassure;
        private ISubjectInterface S;
        public CurrentConditionsDisplay(ISubjectInterface subject)
        {
            S = subject;
            S.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Current Conditions: "+ Temperature+ "F degrees "+Humidity+"% humidity");
        }

        public void update(float temp, float humidity, float preassure)
        {
            Temperature = temp;
            Humidity = humidity;
            Preassure = preassure;
            Display();
        }
    }
}
