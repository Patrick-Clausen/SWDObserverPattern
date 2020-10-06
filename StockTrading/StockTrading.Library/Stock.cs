namespace StockTrading.Library
{
    public class Stock : NormalSubject
    {
        public Stock(string name, double stockPrice)
        {
            Name = name;
            price = stockPrice;
        }

        public string Name;

        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                Notify();
            }
        }

        public override object Get()
        {
            return price;
        }

    }
}