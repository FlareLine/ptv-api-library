namespace PTVWrapper.Models
{
    public class RouteType
    {
        public string Name { get; set; }
        public int Type { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="RouteType"/> object
        /// </summary>
        /// <param name="nm">Readable name</param>
        /// <param name="ty">Type ID as a <see langword="string"/></param>
        public RouteType(string nm, int ty)
        {
            Name = nm;
            Type = ty;
        }
    }
}