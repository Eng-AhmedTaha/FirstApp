﻿using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;
namespace FirstApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class Invoice : Controller
    {
        public IActionResult Index()
        {
            List<Customers> lstCustomers = new List<Customers>();
            lstCustomers.Add(new Customers()
            {
                Id = 1,
                Name = "ahmed"
            });

            lstCustomers.Add(new Customers()
            {
                Id = 2,
                Name = "mohamed"
            });

            lstCustomers.Add(new Customers()
            {
                Id = 3,
                Name = "mostafa"
            });

            ViewBag.Customers = lstCustomers;

            var invoice = new FirstApp.Models.Invoice();
            invoice.InvoiceItems.Add(new InvoiceDetails()
            {
                Price = 50,
                Quantity = 1,
                ItemId = 1
            });
            invoice.InvoiceItems.Add(new InvoiceDetails()
            {
                Price = 80,
                Quantity = 4,
                ItemId = 2
            });

            invoice.InvoiceItems.Add(new InvoiceDetails()
            {
                Price = 100,
                Quantity = 6,
                ItemId = 7
            });

            return View(invoice);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(FirstApp.Models.Invoice invoice)
        {
            if (!ModelState.IsValid)
                View("Index", invoice);


            // save employee in database

            return View("Index", invoice);
        }
    }
}
