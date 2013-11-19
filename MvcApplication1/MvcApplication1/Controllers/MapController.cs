using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcApplication1.Controllers
{
    public class MapController : Controller
    {
        //
        // GET: /Map/

        public ActionResult Index(string postcode)
        {
            var mv = new PostcodeModel { Postcode = postcode };
            return View(mv);
        }

    }
}
