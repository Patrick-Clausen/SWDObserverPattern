using System;

namespace StockTrading.Library
{
    public interface ISubject
    {
        //void Attach(NormalSubject obs);
        void Detach(IObserver obs);
        void Attach(IObserver obs);

        object Get();
    }
}