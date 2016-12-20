using System.Collections.Generic;
using System.Security.Policy;

namespace city_simulation
{
    public class CitySimilation
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
        }
    }
}