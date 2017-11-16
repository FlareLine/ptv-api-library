using System.Collections.Generic;

namespace PTVWrapper.Models
{
    public class Stop
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public RouteType RouteType { get; set; }
        public Location Location { get; set; }

        public Dictionary<string, bool> Amentities { get; set; }
        public Dictionary<string, bool> Accessibility { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="Stop"/> object
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="nm">Name</param>
        /// <param name="ty">Station Type</param>
        /// <param name="ds">Description</param>
        /// <param name="rt">Stop <see cref="Models.RouteType"/></param>
        /// <param name="lc">Location as a <see cref="Models.Location"/></param>
        /// <param name="am">A <see cref="Dictionary{String, Boolean}"/> or <see langword="null"/> if not available</param>
        /// <param name="ac">A <see cref="Dictionary{String, Boolean}"/> or <see langword="null"/> if not available</param>
        public Stop(int id, string nm, string ty, string ds, RouteType rt, Location lc, Dictionary<string, bool> am, Dictionary<string, bool> ac)
        {
            Id = id;
            Name = nm;
            Type = ty;
            Description = ds;
            RouteType = rt;
            Location = lc;
            Amentities = am;
            Accessibility = ac;
        }
    }
}
