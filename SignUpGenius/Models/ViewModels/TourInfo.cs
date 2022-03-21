using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models.ViewModels
{
    public class TourInfo
    {
        public int TotalNumTours { get; set; }
        public int ToursPerPage { get; set; }
        public int CurrentPage { get; set; }

        //Figure out how many pages we need + Rounding
        public int TotalTours => (int)Math.Ceiling((double)TotalNumTours / ToursPerPage);
    }
}
