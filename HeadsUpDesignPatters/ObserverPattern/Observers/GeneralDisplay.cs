using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.ObserverPattern.Observers
{
    public class GeneralDisplay : IObserver<WeatherData>
    {
        public void Update(WeatherData notification)
        {
            Console.WriteLine($"GENERAL DISPLAY:" +
                $"\t{DateTime.Now.ToShortDateString()}" +
                $"\t{DateTime.Now.ToShortTimeString()}\n");
        }
    }
}
