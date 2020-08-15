using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.StrategyPatter.QuackBehaviours
{
    public class Squeak : IQuackBehaviour
    {
        public string Quack()
        {
            return "Squeak!";
        }
    }
}
