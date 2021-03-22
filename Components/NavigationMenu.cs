using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIB.Models.Interface;

namespace UIB.Components
{
    public class NavigationMenu : ViewComponent
    {
        public ISubjectRep rep;
        public NavigationMenu(ISubjectRep db)
        {
            rep = db;
        }
        public IViewComponentResult Invoke()
        {
            return View(rep.Subjects.OrderBy(x=>x));
        }
    }
}
