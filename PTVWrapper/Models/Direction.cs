using System;
using System.Collections.Generic;

namespace PTVWrapper.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Route Route { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="Direction"/> object
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="nm">Name</param>
        /// <param name="rt">The <see cref="Models.Route"/> the <see cref="Direction"/> corresponds to</param>
        public Direction(int id, string nm, Route rt)
        {
            Id = id;
            Name = nm;
            Route = rt;
        }
    }
}
