using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.StrategyPatter.FlyBehaviours
{
    public class FlyWithJetPack : IFlyBehaviour
    {
        public string Fly()
        {
            return "3, 2, 1, Lift-off!";
        }
    }
}
