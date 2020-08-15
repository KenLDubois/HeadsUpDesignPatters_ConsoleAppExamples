using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.StrategyPatter.FlyBehaviours
{
    public class DoNotFly : IFlyBehaviour
    {
        public string Fly()
        {
            return "Don't fly";
        }
    }
}
