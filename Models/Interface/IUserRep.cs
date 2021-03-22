using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIB.Models.Interface
{
    public interface IUserRep
    {
        public IQueryable<User> Users { get; }
    }
}
