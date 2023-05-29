using DiyetSefii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiyetSefii.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result(Diyet diyet)
        {
            //swhtch case kullan 
            return View();
        }
    }
}