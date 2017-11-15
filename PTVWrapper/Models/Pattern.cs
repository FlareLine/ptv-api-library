using System;
using System.Collections.Generic;

namespace PTVWrapper.Models
{
    public class Pattern
    {
        List<Departure> Departures { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="Pattern"/> object
        /// </summary>
        /// <param name="dp"></param>
        public Pattern(List<Departure> dp)
        {
            Departures = dp;
        }
    }
}
