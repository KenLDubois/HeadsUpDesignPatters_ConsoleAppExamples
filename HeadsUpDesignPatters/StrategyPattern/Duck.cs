using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.StrategyPatter
{
    public abstract class Duck
    {
        internal IFlyBehaviour flyBehaviour;
        internal IQuackBehaviour quackBehaviour;

        public string PerformQuackBehaviour()
        {
            return quackBehaviour.Quack();
        }

        public string PerformFlyBehaviour()
        {
            return flyBehaviour.Fly();
        }

        public abstract string Display();
    }
}
