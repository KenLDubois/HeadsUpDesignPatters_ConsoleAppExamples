using HeadsUpDesignPatters.ObserverPattern.Observers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace HeadsUpDesignPatters.ObserverPattern
{
    public class ObserverPatternRunner : IPatternRunner
    {
        private static Random rnd;
        private static ForecastDisplay display;
        private static GeneralDisplay general;
        private static StatsDisplay stats;
        private static WeatherStation station;
        private static WeatherData data;
        private static Timer timer;

        public ObserverPatternRunner()
        {
            rnd = new Random();
            display = new ForecastDisplay();
            general = new GeneralDisplay();
            stats = new StatsDisplay();
            station = new WeatherStation();
            data = new WeatherData();

            station.AddObserver(display);
            station.AddObserver(general);
            station.AddObserver(stats);
            station.State = data;

        }

        public void Run()
        {
            UpdateObservable();

            timer = new Timer(1500);

            timer.Elapsed += timer_Elapsed;
            timer.Start();

            var exit = Console.ReadKey();
            
            if(exit != null)
            {
                timer.Stop();
                timer.Close();
                timer.Dispose();
            }

        }

        private static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            UpdateObservable();
        }

        private static void UpdateObservable()
        {
            Console.Clear();
            data.Humidity = rnd.NextDouble() * 100;
            data.Temperature = rnd.NextDouble() * 100;
            data.Pressure = rnd.NextDouble() * 100;
            station.SetChanges();
            station.NotifyObservers();

            Console.WriteLine("\nPress key button to return to the main menu.");
        }
    }
}
