namespace PTVWrapper.Models
{
    public class Outlet
    {
        public string Business { get; set; }
        public Location Location { get; set; }
        public string Suburb { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="Outlet"/> object
        /// </summary>
        /// <param name="bn">Business name</param>
        /// <param name="lc">Location</param>
        /// <param name="sb">Suburb name</param>
        public Outlet(string bn, Location lc, string sb)
        {
            Business = bn;
            Location = lc;
            Suburb = sb;
        }
    }
}
