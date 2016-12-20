namespace city_simulation
{
    public class TradeRoute
    {
        private City _node_ichi;
        private City _node_ni;
        private int _distance;

        public TradeRoute(City first, City second, int distance)
        {
            _node_ichi = first;
            _node_ni = second;
            _distance = distance;
        }

        public City FirstCity
        {
            get { return _node_ichi; }
            set { _node_ichi = value; }
        }

        public City SecondCity
        {
            get { return _node_ni; }
            set { _node_ni = value; }
        }

        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }
    }
}