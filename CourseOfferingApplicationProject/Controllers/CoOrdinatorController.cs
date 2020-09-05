using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseOfferingApplicationProject.Services;
using CourseOfferingApplicationProject.ViewModels;

namespace CourseOfferingApplicationProject.Controllers
{
    public class CoOrdinatorController : Controller
    {
        //
        // GET: /CoOrdinator/

        public ActionResult Index()
        {
            CoOrdinatorService coOrdinatorService= new CoOrdinatorService();
            coOrdinatorService.GetCoOrdinator();
            return View(coOrdinatorService.GetCoOrdinator());
        }

    }
}
