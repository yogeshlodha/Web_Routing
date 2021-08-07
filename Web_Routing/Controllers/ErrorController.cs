using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Routing.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult PageNotFound()
        {
            return View();
        }

        [HandleError]
        public ActionResult ErrorPage1()
        {
            return View();
        }
    }
}