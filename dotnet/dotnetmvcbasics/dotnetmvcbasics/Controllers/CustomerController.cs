using dotnetmvcbasics.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetmvcbasics.Controllers
{
    public class CustomerController : Controller
    {

        static List<Customer> customers = new List<Customer>();
        // GET: CustomerController
        public ActionResult Index()
        {
            /**
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Rohit";
            customer.Email = "rohit@gmail.com";
            customer.Mobile = 9845547471;
            customer.location = "Chennai";

            customers.Add(customer);
            **/
            return View(customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {

            Customer customerToDisplay = null;

            foreach(Customer cutomer in customers)
            {
                if(cutomer.Id == id)
                {
                    customerToDisplay = cutomer;
                }
            }
            return View(customerToDisplay);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //   public ActionResult Create(IFormCollection collection)
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

            Customer customerToEdit = null;

            foreach (Customer cutomer in customers)
            {
                if (cutomer.Id == id)
                {
                    customerToEdit = cutomer;
                }
            }
            return View(customerToEdit);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //  public ActionResult Edit(int id, IFormCollection collection)
        public ActionResult Edit(int id, Customer customer)
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
            Customer customerToDelete = null;

            foreach (Customer cutomer in customers)
            {
                if (cutomer.Id == id)
                {
                    customerToDelete = cutomer;
                }
            }

            return View(customerToDelete);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {

                List<Customer> customersAfterDelete = new List<Customer>();
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].Id != customer.Id)
                    {
                        customersAfterDelete.Add(customers[i]);
                    }
                }
                customers = customersAfterDelete;

                //   todosList.Remove(todos);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
