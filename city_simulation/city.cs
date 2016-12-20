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
        }

        public List<Product> Products
        {
            get { return _products; }
            set { _products = value; }
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