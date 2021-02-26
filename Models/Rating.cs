using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRating.Models
{
    public class Rating
    {
        public int id { get; set; }
        public int userId { get; set; }
        public decimal rating { get; set; }
    }
}
