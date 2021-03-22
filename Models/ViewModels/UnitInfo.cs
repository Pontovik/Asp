using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIB.Models.ViewModels
{
    public class UnitInfo
    {
        public Subject Subject { get; set; }
        public IEnumerable<Unit> Units { get; set; }
    }
}
