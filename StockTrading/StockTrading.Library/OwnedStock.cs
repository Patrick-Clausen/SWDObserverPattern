using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading.Library
{
    public class OwnedStock
    {
        private readonly string _id;
        private readonly Stock _stock;
        public OwnedStock(Stock stock, string assignedID)
        {
            _stock = stock;
            _id = assignedID;

        }

        public string getID()
        {
            return _id;
        }

        public Stock getStock()
        {
            return _stock;
        }
    }
}
