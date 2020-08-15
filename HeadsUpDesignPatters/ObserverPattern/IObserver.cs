using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.ObserverPattern
{
    public interface IObserver<TNotification>
    {
        public void Update(TNotification notification);
    }
}
