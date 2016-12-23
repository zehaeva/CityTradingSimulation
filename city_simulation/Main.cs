using System.Collections.Generic;
using System.Windows.Forms;

namespace city_simulation
{
    public class CitySimulation
    {
        public static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            List<TradeRoute> tradeRoutes = new List<TradeRoute>();

            cities.Add(new City("Utica"));
            cities.Add(new City("Syracuse"));
            cities.Add(new City("Albany"));
            cities.Add(new City("Watertown"));
            cities.Add(new City("Rochester"));
            cities.Add(new City("Binghamton"));
            cities.Add(new City("Ithaca"));

            var food = new Item("Food");
            var iron = new Item("Iron");

            foreach (var city in cities)
            {
                city.Products.Add(new Product(food, 50, 50, -50));
            }
            cities[0].Products.Add(new Product(iron, 50, 50, 50));

            cities[0].Neighbors.Add(cities[1]);
            cities[0].Neighbors.Add(cities[2]);
            cities[0].Neighbors.Add(cities[3]);
            cities[0].Neighbors.Add(cities[5]);

            tradeRoutes.Add(new TradeRoute(cities[0], cities[1], 45));
            tradeRoutes.Add(new TradeRoute(cities[0], cities[2], 90));
            tradeRoutes.Add(new TradeRoute(cities[0], cities[3], 90));
            tradeRoutes.Add(new TradeRoute(cities[0], cities[5], 90));
            tradeRoutes.Add(new TradeRoute(cities[1], cities[4], 90));
            tradeRoutes.Add(new TradeRoute(cities[1], cities[5], 45));
            tradeRoutes.Add(new TradeRoute(cities[1], cities[6], 90));
            tradeRoutes.Add(new TradeRoute(cities[5], cities[6], 30));
            tradeRoutes.Add(new TradeRoute(cities[4], cities[6], 90));
            tradeRoutes.Add(new TradeRoute(cities[3], cities[4], 135));

            var form = new ViewWindow(tradeRoutes, cities);

            Application.EnableVisualStyles();
            Application.Run(form);
        }
    }
}