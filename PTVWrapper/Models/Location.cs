namespace PTVWrapper.Models
{
    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="Location"/> object
        /// </summary>
        /// <param name="lt">Latitude as a </param>
        /// <param name="ln"></param>
        public Location(double lt, double ln)
        {
            Latitude = lt;
            Longitude = ln;
        }
    }
}