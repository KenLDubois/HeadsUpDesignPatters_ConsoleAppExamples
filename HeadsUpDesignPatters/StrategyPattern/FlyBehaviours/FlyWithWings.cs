using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.StrategyPatter.FlyBehaviours
{
    public class FlyWithWings : IFlyBehaviour
    {
        public string Fly()
        {
            return "Flap flap flap!";
        }
    }
}
