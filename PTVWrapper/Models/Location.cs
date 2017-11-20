namespace PTVWrapper.Models
{
    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="Location"/> object
        /// </summary>
        /// <param name="lt">Latitude as a <see langword="double"/></param>
        /// <param name="ln">Longitude as a <see langword="double"/></param>
        public Location(double lt, double ln)
        {
            Latitude = lt;
            Longitude = ln;
        }
    }
}