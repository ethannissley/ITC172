using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunityAssist2018.Models;

namespace CommunityAssist2018.Controllers
{
    public class DonationController : Controller
    {
        // GET: Donation
        public ActionResult Index()
        {
            if (Session["reviewKey"] == null)
            {
                Message m = new Message();
                m.MessageText = "Must be logged in to enter Donation";
                return RedirectToAction("Result", m);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Amount, PersonKey, Date")]NewDonation nb)
        {
            CommunityAssist2017Entities db = new CommunityAssist2017Entities();

            nb.PersonKey = (int)Session["reviewKey"];

            Donation a = new Donation();
            a.DonationAmount = nb.Amount;
            a.DonationDate = DateTime.Now;
            a.PersonKey = nb.PersonKey;
            a.DonationConfirmationCode = new Guid();
            db.Donations.Add(a);
            db.SaveChanges();

            Message m = new Message();
            m.MessageText = "Thank you, the donation has been added";

            return View("Result", m);
        }

        public ActionResult Result(Message m)
        {
            return View(m);
        }
    }
}
