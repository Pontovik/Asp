using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIB.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Time { get; set; }
        public List<Unit> Units { get; set; }
        public Subject()
        {
            Units = new List<Unit>();
        }
    }
}
