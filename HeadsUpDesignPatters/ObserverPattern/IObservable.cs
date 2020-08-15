using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.ObserverPattern
{
    public interface IObservable<TNotification>
    {
        public void AddObserver(IObserver<TNotification> observer);
        public void RemoveObserver(IObserver<TNotification> observer);
        public void NotifyObservers();
        public void SetChanges();
    }
}
