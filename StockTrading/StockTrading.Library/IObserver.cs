﻿namespace StockTrading.Library
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}