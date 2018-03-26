using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunityAssist2018.Models;

namespace CommunityAssist2018.Controllers
{
    public class GrantApplicationController : Controller
    {
        CommunityAssist2017Entities db = new CommunityAssist2017Entities();
        // GET: GrantApplication
        public ActionResult Index()
        {
            if (Session["reviewKey"] == null)
            {
                Message m = new Message();
                m.MessageText = "You must be logged in to apply for a grant";
                return RedirectToAction("Result", m);
            }
            ViewBag.GrantTypeKey = new SelectList(db.GrantTypes, "GrantTypeKey", "GrantTypeName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "PersonKey, GrantAppicationDate, GrantTypeKey, GrantApplicationRequestAmount, GrantApplicationReason, GrantApplicationStatusKey, GrantApplicationAllocationAmount")]GrantApplication r)
        {
            r.GrantApplicationStatusKey = 1;
            r.PersonKey = (int)Session["reviewKey"];
            r.GrantAppicationDate = DateTime.Now;
            db.GrantApplications.Add(r);
            db.SaveChanges();
            Message m = new Message();
            m.MessageText = "Thank you for your application";
            return View("Result", m);
        }

        public ActionResult Result(Message m)
        {
            return View(m);
        }
    }
}
