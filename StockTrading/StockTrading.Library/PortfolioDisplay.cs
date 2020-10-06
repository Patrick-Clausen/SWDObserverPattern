using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace StockTrading.Library
{
    public class PortfolioDisplay : IObserver
    {
        public void Update(ISubject subject)
        {
            Portfolio portfolio = ((Portfolio) subject.Get());
            Console.Clear();

            Console.WriteLine("Portfolio");
            Console.WriteLine("################"+portfolio.Owner+ "################");
            Console.WriteLine("");
            foreach (OwnedStock stock in portfolio.OwnedStocks)
            {
                Console.Write(stock.getID());
                Console.Write('\t');
                Console.Write(stock.getStock().Name);
                Console.Write('\t');
                Console.WriteLine(stock.getStock().Price);
            }
            Console.WriteLine("");
            Console.WriteLine("Total: "+portfolio.Total);
        }
    }
}
