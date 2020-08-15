using HeadsUpDesignPatters.ObserverPattern;
using HeadsUpDesignPatters.StrategyPatter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HeadsUpDesignPatters
{
    class Program
    {
        private static List<IPatternRunner> PatterList = new List<IPatternRunner> {
            new StrategyPatternRunner(),
            new ObserverPatternRunner()
        };

        static void Main(string[] args)
        {
            CreateMenu();
            var selection = Console.ReadLine();
            int selectionInt;

            if(int.TryParse(selection, out selectionInt) && selectionInt > 0 && selectionInt <= PatterList.Count)
            {
                Console.Clear();
                PatterList[selectionInt - 1].Run();
                Console.Clear();
            }

            Main(args);
        }

        private static void CreateMenu()
        {
            Console.WriteLine("Please select a pattern to demo by number:");
            Console.WriteLine("==========================================\n");

            for (int i = 0; i < PatterList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {GetPatternName(PatterList[i])}");
            }
        }

        private static string GetPatternName(IPatternRunner pattern)
        {
            var name = pattern.GetType().Name;

            name = name.Replace("Runner", "", StringComparison.OrdinalIgnoreCase);

            name = string.Concat(name.Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');

            return name;
        }
    }
}
