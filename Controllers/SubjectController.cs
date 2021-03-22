using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIB.Models;
using UIB.Models.Interface;
using UIB.Models.ViewModels;

namespace UIB.Controllers
{
    public class SubjectController : Controller
    {
        private ISubjectRep db;
        private IUnitRep un;
        public SubjectController(ISubjectRep rep, IUnitRep help)
        {
            db = rep;
            un = help;
          

        }
        
        public ViewResult List(string category)
        {
           

            return View(db.Subjects.FirstOrDefault(cat => cat.Name == category));
        }
    }
}