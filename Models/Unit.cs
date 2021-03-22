using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIB.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public int? SubjectId { get; set; }
    }
}
