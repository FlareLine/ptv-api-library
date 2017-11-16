namespace PTVWrapper.Models
{
    public class Run
    {
        public int Id { get; set; }

        public Route Route { get; set; }
        public Stop Final { get; set; }

        public string Status { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="Run"/> object
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="rt">Run <see cref="Models.Route"/></param>
        /// <param name="fn">Final <see cref="Stop"/></param>
        /// <param name="st">Status</param>
        public Run(int id, Route rt, Stop fn, string st)
        {
            Id = id;
            Route = rt;
            Final = fn;
            Status = st;
        }
    }
}
