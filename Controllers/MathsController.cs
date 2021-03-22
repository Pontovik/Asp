using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIB.Models;
using UIB.Models.Counts;
using UIB.Models.Interface;

namespace UIB.Controllers
{
    public class MathsController : Controller
    {
        private Counts counts;
      
        public MathsController()
        {
            counts = new Counts();
        }
       
        [HttpGet]
        public ViewResult Lejandr() => View();
        [HttpPost]
        public RedirectToActionResult Lejandr(CountLejandr co)=> RedirectToAction(nameof(ResultLejandr), co);
        [HttpGet]
        public ViewResult Exponentiation() => View();
        
        [HttpPost]
        public RedirectToActionResult Exponentiation(CountExp co) => RedirectToAction(nameof(ResultExp), co);
       
        [HttpGet]
        public ViewResult Euclid() => View();

        [HttpPost]
        public RedirectToActionResult Euclid(CountEuclid co) => RedirectToAction(nameof(ResultEuclid), co);
        
        [HttpGet]
        public ViewResult EqSolution() => View();
       
        [HttpPost]
        public RedirectToActionResult EqSolution(CountEqSol co) => RedirectToAction(nameof(ResultEqSol), co);
       public ViewResult ResultLejandr(CountLejandr co)
        {
            co.Lejandr();
            if (co.Lejandr() == 1 || co.Lejandr()==0)
            {
                ViewBag.Message = "Сравнение разрешимо";
                co.ResultLejandr.Add(co.Answer());
                co.ResultLejandr.Add(co.SubMod(co.Answer()));
            }
            else
            {
                co.Res = co.SubMod(co.Res+2);
                ViewBag.Message = "Сравнение не разрешимо";
            }
            return View(co);
        }
        public ViewResult ResultExp(CountExp co)
        {
            
            counts.CountExp = co;
            counts.CountExp.Res = counts.CountExp.Exp();
       
            
            return View(counts.CountExp);
        }
        public ViewResult ResultEuclid(CountEuclid co)
        {

            counts.CountEuclid = co;
            counts.CountEuclid.Euclid();

            return View(counts.CountEuclid);
        }
        public ViewResult ResultEqSol(CountEqSol co)
        {
           
            counts.CountEqSol = co;
            counts.CountEqSol.Matrix = co.Solution();
            return View(counts.CountEqSol);
        }
    }
}
