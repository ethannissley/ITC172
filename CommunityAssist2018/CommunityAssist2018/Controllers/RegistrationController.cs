using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunityAssist2018.Models;

namespace CommunityAssist2018.Controllers
{
    public class RegistrationController : Controller
    {
        //CommunityAssist2018 db = new CommunityAssist2018();
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "NewPersonLastName,NewPersonFirstName,NewPersonEmail,NewPersonPlainPassword,NewPersonApartment,NewPersonStreet,NewPersonCity,NewPersonState,NewPersonZipcode,NewPersonPhone")]NewPerson r)
        {
            CommunityAssist2017Entities db = new CommunityAssist2017Entities(); 

            int result = db.usp_Register(r.NewPersonLastName, r.NewPersonFirstName, r.NewPersonEmail, r.NewPersonPlainPassword, r.NewPersonApartment, r.NewPersonStreet, r.NewPersonCity, r.NewPersonState, r.NewPersonZipcode, r.NewPersonPhone);

            if (result != -1)
            {
                return RedirectToAction("Result");
            }

            return View("Index");
        }
    }
}
