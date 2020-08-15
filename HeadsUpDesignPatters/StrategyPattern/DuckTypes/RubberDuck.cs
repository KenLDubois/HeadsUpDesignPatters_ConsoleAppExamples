using HeadsUpDesignPatters.StrategyPatter.FlyBehaviours;
using HeadsUpDesignPatters.StrategyPatter.QuackBehaviours;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.StrategyPatter.DuckTypes
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new DoNotFly();
            quackBehaviour = new Squeak();
        }

        public override string Display()
        {
            return "Rubber Duck";
        }
    }
}
