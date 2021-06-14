using System.Collections.Generic;

namespace Observer
{
    public abstract class Subject
    {
        public List<Observer> Observers { get; } = new List<Observer>();

        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            Observers.ForEach(observer => observer.Update());
        }
    }
}
