using System;
using System.Collections.Generic;
using System.Text;

namespace HeadsUpDesignPatters.ObserverPattern
{
    public abstract class Observable<TNotification> : IObservable<TNotification>
    {
        public IList<IObserver<TNotification>> Observers;
        public TNotification State;
        public bool HasChanges;

        public Observable()
        {
            Observers = new List<IObserver<TNotification>>();
            HasChanges = false;
        }

        public void AddObserver(IObserver<TNotification> observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver<TNotification> observer)
        {
            Observers.Remove(observer);
        }

        public void SetChanges()
        {
            HasChanges = true;
        }

        public void NotifyObservers()
        {
            if (HasChanges != true)
                return;

            foreach(var observer in Observers)
            {
                observer.Update(State);
            }

            HasChanges = false;
        }
    }
}
