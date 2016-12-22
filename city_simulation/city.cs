using System.Collections.Generic;

namespace city_simulation
{
    public class City : Step
    {
        private List<Product> _products;
        private string _name;

        public City(string name)
        {
            _name = name;
            _products = new List<Product>();
        }

        public List<Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void nextTurn()
        {
            foreach (var x in _products)
            {
                x.nextTurn();
            }
        }
    }
}