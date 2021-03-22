using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIB.Models.Interface;

namespace UIB.Models.Repository
{
    public class EFSubjectRep : ISubjectRep
    {
        private AppDbContext db;
        public EFSubjectRep(AppDbContext rep)
        {
            db = rep;
        }
        public IQueryable<Subject> Subjects => db.Subjects;
    }
}
