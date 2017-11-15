using System;
using System.Collections.Generic;

namespace PTVWrapper.Models
{
    public class Departure
    {
        public Stop Stop { get; set; }
        public Route Route { get; set; }
        public Run Run { get; set; }
        public Direction Direction { get; set; }
        public List<Disruption> Disruptions { get; set; }

        public DateTime Scheduled { get; set; }
        public DateTime Estimated { get; set; }

        public bool AtPlatform { get; set; }
        public int Platform { get; set; }

        public string Flags { get; set; }

        /// <summary>
        /// Constructor for creating a new <see cref="Departure"/> object
        /// </summary>
        /// <param name="st"><see cref="Models.Stop"/> object</param>
        /// <param name="rt"><see cref="Models.Route"/> object</param>
        /// <param name="rn"><see cref="Models.Run"/> object</param>
        /// <param name="dr"><see cref="Models.Direction"/> object</param>
        /// <param name="ds">A <see cref="List{Disruption}"/> or <see langword="null"/> if not available</param>
        /// <param name="sc">Scheduled <see cref="DateTime"/></param>
        /// <param name="es">Estimated <see cref="DateTime"/> or <see langword="null"/> if not available</param>
        /// <param name="at">Service at platform</param>
        /// <param name="pl">Platform number</param>
        /// <param name="fl">Flags or <see langword="null"/> if not available</param>
        public Departure(Stop st, Route rt, Run rn, Direction dr, List<Disruption> ds, DateTime sc, DateTime? es, bool at, int pl, string fl)
        {
            Stop = st;
            Route = rt;
            Run = rn;
            Direction = dr;
            Disruptions = ds;
            Scheduled = sc;
            Estimated = es ?? sc;
            AtPlatform = at;
            Platform = pl;
            Flags = fl ?? "None";
        }
    }
}
