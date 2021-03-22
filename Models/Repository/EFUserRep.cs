using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIB.Models.Interface;

namespace UIB.Models.Repository
{
    public class EFUserRep : IUserRep
    {
        private AppDbContext db;
        public EFUserRep(AppDbContext rep)
        {
            db = rep;
        }
        public IQueryable<User> Users => db.Users;
    }
}
