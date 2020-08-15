using HeadsUpDesignPatters.StrategyPatter.DuckTypes;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// ------------------------
/// Strategy Pattern Basics:
/// ------------------------
/// Strategy patter is useful when you have a parent class that gets inherited by a lot of 
/// different sub-classes and those sub-classes have methods that sometimes vary and sometimes are
/// shared (like, you have a few different versions of the methods so you don't want to just override
/// them because you want to be able to change all the classes with a particular implementation of the
/// method at once). The basic way to accomplish this is as follows:
/// 
/// 1. Build an interface or abstract base class so its sub-classes can be grouped
/// 2. Separate out the methods that are likely to change across sub-classes
/// 3. Create an interface for each method that is likely to change has a signature to 'Perform' the variable method
/// 4. Create a class for each variation of these variable methods that implements the method's interface
/// 5. Give the parent class a private property that is typed as the variable method's interface
/// 6. Create a method in the parent class that calls the interface's 'Perform' method
/// 7. In the sub-classes constructor, assign the appropriate concrete class to the privat property that accepts
///    the 'Perform' interface type
///    
/// </summary>
namespace HeadsUpDesignPatters.StrategyPatter
{
    public class StrategyPatternRunner : IPatternRunner
    {
        public void Run()
        {
            var ducks = new List<Duck>
            {
                new MallardDuck(),
                new RubberDuck()
            };

            foreach(var duck in ducks)
            {
                Console.WriteLine($"Display: {duck.Display()}\t" +
                    $"Quack: {duck.PerformQuackBehaviour()}\t" +
                    $"Fly: {duck.PerformFlyBehaviour()}\n");
            }

            Console.WriteLine("Press key button to return to the main menu.");
            Console.ReadLine();
        }
    }
}
