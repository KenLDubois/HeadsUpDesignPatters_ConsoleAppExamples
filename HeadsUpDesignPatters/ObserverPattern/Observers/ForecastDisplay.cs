using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.ObserverPattern.Observers
{
    public class ForecastDisplay : IObserver<WeatherData>
    {
        public void Update(WeatherData notification)
        {
            Console.WriteLine("FORECAST:");

            var probToRain = notification.Humidity / notification.Pressure;
            if(probToRain > 0.75)
            {
                Console.WriteLine($"It's gonna rain!\t({probToRain.ToString("N3")})\n");
                return;
            }
            if(notification.Temperature > 75)
            {
                Console.WriteLine("It's hot!\n");
                return;
            }
            if(notification.Temperature < 25)
            {
                Console.WriteLine("It's cold!\n");
                return;
            }

            Console.WriteLine("Nothing to report\n");
        }
    }
}
