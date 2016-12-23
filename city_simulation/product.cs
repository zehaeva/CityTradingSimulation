using System;
using System.Security.Policy;

namespace city_simulation
{
    public interface Step
    {
        void nextTurn();
    }

    public class Product : Step
    {
        private Item _item;
        private int _cost;
        private int _stockpile;
        private int _production_rate;
        private int _min_level;
        private int _max_level;

        public Product(Item item, int cost, int stockpile, int productionRate)
        {
            _item = item;
            _cost = cost;
            _stockpile = stockpile;
            _production_rate = productionRate;
            _min_level = 50;
            _max_level = 500;
        }

        public Item Item
        {
            get { return _item; }
            set { _item = value; }
        }

        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public int StockPile
        {
            get { return _stockpile; }
            set { _stockpile = value; }
        }

        public int ProductionRate
        {
            get { return _production_rate; }
            set { _production_rate = value; }
        }

        public Boolean Sell
        {
            get { return _stockpile > _min_level; }
        }

        public Boolean Buy
        {
            get { return _stockpile <= _min_level; }
        }

        public void nextTurn()
        {
            _stockpile += _production_rate;
        }
    }
}