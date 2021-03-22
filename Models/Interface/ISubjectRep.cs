using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIB.Models.Interface
{
    public interface ISubjectRep
    {
        public IQueryable<Subject> Subjects { get; }
    }
}
