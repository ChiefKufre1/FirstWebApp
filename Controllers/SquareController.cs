using System;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{


    public class SquareController : Controller {
[HttpPost]
        public ActionResult Sqrt( string FirstNumber, string SecondNumber)
        
        {

          int Number1 = Convert.ToInt32(FirstNumber);
          double SqrtNumber1 = Math.Sqrt(Number1);
          int Number2 = Convert.ToInt32(SecondNumber);
          double SqrtNumber2 = Math.Sqrt(Number2);
          ViewBag.Result1 = SqrtNumber1;
          ViewBag.Result2 = SqrtNumber2;

          
            return View();
        
        }

    }


    }
