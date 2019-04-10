using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MeyerIndustriesWebsite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Home()
        {
            return View();
        }
        
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Register()
        {
            //Dropdownlist for Countries
            ViewBag.DropDownValueCountires = new SelectList(new[] { "Canada","United States" });

            ViewBag.DropDownValueStates = new SelectList(new[] { "Alaska", "Alabama" });

            MeyerIndustriesWebsite.Models.Register register = new MeyerIndustriesWebsite.Models.Register();
            //register.Email = "JoeMeyer@gmail.com";
            return View(register);
        }

        [HttpPost]
        public ActionResult Register(MeyerIndustriesWebsite.Models.Register register)
        {
            //register.Email = register.Email;
            ModelState.Remove("Email");
            return View(register);
        }


        public ActionResult MeyerIndustriesJobOp()
        {
            return View();
        }

        public ActionResult MeyerIndustriesNews()
        {
            return View();
        }

        public ActionResult MeyerIndustriesInvest()
        {
            return View();
        }

        public ActionResult MeyerIndustriesBuisness()
        {
            return View();
        }

        public ActionResult ProductsCameraGear()
        {
            return View();
        }

        public ActionResult ProductsWeapons()
        {
            return View();
        }

        public ActionResult ProductsClothing()
        {
            return View();
        }

        public ActionResult AccountManage()
        {
            return View();
        }

        public ActionResult AccountPurchases()
        {
            return View();
        }

        public ActionResult AccountShipping()
        {
            return View();
        }

		public ActionResult ProductsPouches()
		{
			return View();
		}

        public ActionResult ReviewWriter()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Wishlist()
        {
            return View();
        }

        public ActionResult NotLogin()
        {
            return View();
        }

        public ActionResult ProductsElectrical()
        {
            return View();
        }
    }
}
