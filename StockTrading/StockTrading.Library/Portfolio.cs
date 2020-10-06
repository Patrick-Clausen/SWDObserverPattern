using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading.Library
{
    public class Portfolio : NormalSubject, IObserver
    {
        public List<OwnedStock> OwnedStocks = new List<OwnedStock>();

        public double Total
        {
            get;
            private set;
        }

        public string Owner
        {
            get;
            private set;
        }

        public Portfolio(string ownerName)
        {
            Owner = ownerName;
        }

        public override object Get()
        {
            return this;
        }

        public void Update(ISubject subject)
        {
            Total = 0;
            foreach (OwnedStock ownedStock in OwnedStocks)
            {
                Total += ownedStock.getStock().Price;
            }

            Notify();
        }
    }
}
