using System;
using System.Collections.Generic;

namespace PTVWrapper.Models
{
    public class Disruption
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }

        public DateTime Published { get; set; }
        public DateTime Updated { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public List<Route> Routes { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="Disruption"/> object
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="tt">Title</param>
        /// <param name="ur">Information URL</param>
        /// <param name="ds">Description</param>
        /// <param name="st">Status</param>
        /// <param name="ty">Type</param>
        /// <param name="pb">Published <see cref="DateTime"/></param>
        /// <param name="up">Updated <see cref="DateTime"/></param>
        /// <param name="fr">From <see cref="DateTime"/></param>
        /// <param name="to">To <see cref="DateTime"/></param>
        /// <param name="rt">A <see cref="List{Route}"/> or <see langword="null"/> if not applicable or available</param>
        public Disruption(int id, string tt, string ur, string ds, string st, string ty, DateTime pb, DateTime up, DateTime fr, DateTime to, List<Route> rt)
        {
            Id = id;
            Title = tt;
            Url = ur;
            Description = ds;
            Status = st;
            Type = ty;
            Published = pb;
            Updated = up;
            From = fr;
            To = to;
            Routes = rt;
        }
    }
}
