using System;
using System.Collections.Generic;

namespace PTVWrapper.Models
{
    public class Route
    {
        public RouteType Type { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="Route"/> object
        /// </summary>
        /// <param name="ty"><see cref="RouteType"/> of <see cref="Route"/></param>
        /// <param name="id">ID</param>
        /// <param name="nm">Name</param>
        /// <param name="nb">Route number (Not ID) as a <see langword="string"/></param>
        public Route(RouteType ty, int id, string nm, string nb)
        {
            Type = ty;
            Id = id;
            Name = nm;
            Number = nb;
        }
    }
}
