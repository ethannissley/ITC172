using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryASP.Models;

namespace BakeryASP.Controllers
{
    public class OrderController : Controller
    {
        BakeryEntities2 db = new BakeryEntities2();

        Order o = new Order();

        // GET: Order

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "SaleDate, EmployeeKey, " +
                                                  "CustomerKey, ProductKey, SaleDetailPriceCharged, " +
                                                  "SaleDetailQuantity, SaleDetailDiscount, SaleDetailSaleTaxPercent, " +
                                                  "SaleDetailEatInTax")]Order o)
        {
            Sale s = new Sale();
            SaleDetail sd = new SaleDetail();
            s.SaleDate = o.SaleDate;
            s.EmployeeKey = o.EmployeeKey;
            s.CustomerKey = o.CustomerKey;
            sd.ProductKey = o.ProductKey;
            sd.SaleDetailPriceCharged = o.SaleDetailPriceCharged;
            sd.SaleDetailQuantity = o.SaleDetailQuantity;
            sd.SaleDetailDiscount = o.SaleDetailDiscount;
            sd.SaleDetailSaleTaxPercent = o.SaleDetailSaleTaxPercent;
            sd.SaleDetailEatInTax = o.SaleDetailEatInTax;
            
            return View("Result");

        }

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Order([Bind(Include = "ItemsOrdered, SubTotal, Total, EatIn")]Order or)
        {
            SaleDetail de = new SaleDetail();
            or.ItemsOrdered = de.SaleDetailQuantity;
            or.Total = or.ItemsOrdered * de.SaleDetailPriceCharged;
            
            return View("Result", or);
        }

        public ActionResult Order()
        {
            return View();
        }

        public ActionResult Result(Order o)
        {
            return View(o);
        }

        
    }
}
