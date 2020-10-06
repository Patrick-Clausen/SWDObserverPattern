using System.Collections.Generic;

namespace StockTrading.Library
{
    abstract class NormalSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver obs)
        {
            observers.Add(obs);
        }

        public void Detach(IObserver obs)
        {
            observers.Remove(obs);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

    }
}