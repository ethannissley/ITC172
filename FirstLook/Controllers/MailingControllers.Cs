using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLook.Models;

namespace FirstLook.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            Mailing m1 = new Mailing();
            m1.FirstName = "Ethan";
            m1.LastName = "Nissley";
            m1.Email = "ethannissley@gmail.com";

            Mailing m2 = new Mailing();
            m2.FirstName = "Steve";
            m2.LastName = "Conger";
            m2.Email = "steve.conger@seattlecolleges.edu";

            Mailing m3 = new Mailing();
            m3.FirstName = "John";
            m3.LastName = "Smith";
            m3.Email = "johnsmith@gmail.com";

            List<Mailing> mailings = new List<Mailing>();
            mailings.Add(m1);
            mailings.Add(m2);
            mailings.Add(m3);

            return View(mailings);
        }
    }
}
