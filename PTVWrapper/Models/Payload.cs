using System.Collections.Generic;

namespace PTVWrapper.Models
{
    /// <summary>
    /// API payload class, containing all the possible objects the PTV API can respond with
    /// </summary>
    public class Payload
    {
        public List<Departure> Departures { get; set; }
        public List<Route> Routes { get; set; }
        public List<Stop> Stops { get; set; }
        public List<Run> Runs { get; set; }
        public List<Pattern> Patterns { get; set; }
        public List<Location> Locations { get; set; }
        public List<Disruption> Disruptions { get; set; }
        public List<RouteType> RouteTypes { get; set; }
        public List<Direction> Directions { get; set; }
    }
}
