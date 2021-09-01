using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    public interface IObserverInterface
    {
        public void update(float temp, float humidity, float preassure);
    }
}
