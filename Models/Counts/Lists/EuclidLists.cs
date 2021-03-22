using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIB.Models.Counts.Lists
{
    public class EuclidLists
    {
        public List<long> Remainders { get; set; } = new List<long>();
        public List<long> Factors { get; set; } = new List<long>();
        public List<long> Results { get; set; } = new List<long>();
        public List<long> Quots { get; set; } = new List<long>();
        public List<long> TempResults { get; set; } = new List<long>();
    }
}
