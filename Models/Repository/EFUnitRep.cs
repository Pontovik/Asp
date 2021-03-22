using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIB.Models.Interface;

namespace UIB.Models.Repository
{
    public class EFUnitRep : IUnitRep
    {
        private AppDbContext db;
        public EFUnitRep(AppDbContext rep)
        {
            db = rep;
            foreach(var sub in db.Subjects.ToList())
            {
                foreach(var un in db.Units)
                {
                    if (un.SubjectId == sub.Id)
                    {
                        if (!sub.Units.Contains(un))
                        {
                            sub.Units.Add(un);
                        }
                    }
                }
            }
        }
        public IQueryable<Unit> Units => db.Units;
    }
}
