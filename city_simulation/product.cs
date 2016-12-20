using System.Security.Policy;

namespace city_simulation
{
    public interface Step
    {
        void nextTurn();
    }

    public class Product : Step
    {
        private string _name;
        private int _cost;
        private int _stockpile;
        private int _production_rate;

        public Product(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
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

        public void nextTurn()
        {
            _stockpile += _production_rate;
        }
    }
}