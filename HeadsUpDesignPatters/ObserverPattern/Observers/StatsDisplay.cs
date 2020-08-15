using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.ObserverPattern.Observers
{
    public class StatsDisplay : IObserver<WeatherData>
    {
        public void Update(WeatherData notification)
        {
            Console.WriteLine("STATS:");
            Console.WriteLine($"Temp: {notification.Temperature.ToString("N1")}\t" +
                $"Pressure: {notification.Pressure.ToString("N1")}\t" +
                $"Humidity: {notification.Humidity.ToString("N1")}\n");
        }
    }
}
