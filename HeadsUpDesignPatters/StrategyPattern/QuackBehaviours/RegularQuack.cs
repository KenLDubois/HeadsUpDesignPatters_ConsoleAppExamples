using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.StrategyPatter.QuackBehaviours
{
    public class RegularQuack : IQuackBehaviour
    {
        public string Quack()
        {
            return "Quack!";
        }
    }
}
