using dotnetbasics.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetbasics.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>();
        // GET: CustomerController
        public ActionResult Index()
        {
            return View(customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            Customer customertoedit=null;

            foreach(Customer customer in customers)
            {
                if (customer.Id == id)
                {
                    customertoedit = customer;
                }
            }

            return View(customertoedit);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //  public ActionResult Create(IFormCollection collection)
        public ActionResult Create(Customer customer)
        {
            try
            {
                customers.Add(customer);
                return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customertoedit = null;

            foreach (Customer customer in customers)
            {
                if (customer.Id == id)
                {
                    customertoedit = customer;
                }
            }
            return View(customertoedit);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        // public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                int editindex = -1;
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].Id == customer.Id)
                    {
                        customers[i] = customer;
                    }
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
