using HeadsUpDesignPatters.StrategyPatter.FlyBehaviours;
using HeadsUpDesignPatters.StrategyPatter.QuackBehaviours;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.StrategyPatter.DuckTypes
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new RegularQuack();
        }

        public override string Display()
        {
            return "Mallard";
        }
    }
}
