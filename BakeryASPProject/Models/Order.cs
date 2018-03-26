using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BakeryASP.Models;


namespace BakeryASP.Models
{
    public class Order
    {

        public int SaleKey { get; set; }
        public DateTime SaleDate { get; set; }
        public int CustomerKey { get; set; }
        public int EmployeeKey { get; set; }
        public int SaleDetailKey { get; set; }
        public int ProductKey { get; set; }
        public decimal SaleDetailPriceCharged { get; set; }
        public int SaleDetailQuantity { get; set; }
        public decimal SaleDetailDiscount { get; set; }
        public decimal SaleDetailSaleTaxPercent { get; set; }
        public decimal SaleDetailEatInTax { get; set; }

        public int ItemsOrdered { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal EatIn { get; set; }

    }
}
