using System.Collections.Generic;
using System.Linq;

namespace city_simulation
{
    public class City : Step
    {
        private List<Product> _products;
        private List<City> _neighbors;
        private string _name;

        public City(string name)
        {
            _name = name;
            _products = new List<Product>();
            _neighbors = new List<City>();
        }

        public List<City> Neighbors
        {
            get { return _neighbors; }
            set { _neighbors = value; }
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

        public List<Product> Buying
        {
            get
            {
                return _products.Where(p => p.Buy).ToList();
            }
            set {}
        }

        public List<Product> Selling
        {
            get
            {
                return _products.Where(p => p.Sell).ToList();
            }
            set {}
        }

        /*
            this is where a city will advance one unit of time
            here we will consume all of the material the city eats
            and produce all the things that a city makes

        */
        public void nextTurn()
        {
        //  do the production thing!
            foreach (var x in _products)
            {
                x.nextTurn();
            }
            int i;
        //  now we need to go through all the neighbors
        //  and sell them our surplus
            foreach (var city in _neighbors)
            {
                i = city.Buying.Count;
            }
        }
    }
}