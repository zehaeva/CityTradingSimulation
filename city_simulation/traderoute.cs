using System.Collections.Generic;

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

        private sealed class NodeIchiNodeNiDistanceEqualityComparer : IEqualityComparer<TradeRoute>
        {
            public bool Equals(TradeRoute x, TradeRoute y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return ((Equals(x._node_ichi, y._node_ichi) && Equals(x._node_ni, y._node_ni)) ||
                        (Equals(x._node_ichi, y._node_ni) && Equals(x._node_ni, y._node_ichi))) &&
                       x._distance == y._distance;
            }

            public int GetHashCode(TradeRoute obj)
            {
                unchecked
                {
                    var hashCode = (obj._node_ichi != null ? obj._node_ichi.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj._node_ni != null ? obj._node_ni.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ obj._distance;
                    return hashCode;
                }
            }
        }

        private static readonly IEqualityComparer<TradeRoute> NodeIchiNodeNiDistanceComparerInstance = new NodeIchiNodeNiDistanceEqualityComparer();

        public static IEqualityComparer<TradeRoute> NodeIchiNodeNiDistanceComparer
        {
            get { return NodeIchiNodeNiDistanceComparerInstance; }
        }
    }
}