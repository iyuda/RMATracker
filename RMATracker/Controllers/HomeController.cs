using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RMATracker.Models;

namespace RMATracker.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //Retrieve new rma from DB
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult SendRMAData()
        {
            RMATracker.Models.RMATracker rma = new Models.RMATracker();
            rma.TrackerID = Request["txtTrackId"];
            rma.RMAType = Request["TypeofRMA"];

            //Send to db...

            return RedirectToAction("Index");
        }
    }
}