using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyerIndustriesWebsite.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult DoubleUSMP()
        {
            return View();
        }

        public ActionResult SingleUSMP()
        {
            return View();
        }
        public ActionResult UnassembledMILTM()
        {
            return View();
        }
        public ActionResult AssembledMILTM()
        {
            return View();
        }

    }
}
