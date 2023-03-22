using dotnetmvcbasics.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetmvcbasics.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> productList = new List<Product>()
            {
                new Product(){Code=1,Name="Smart phone",Description="64 PX camera",Supplier="Samsung",Price=50000 },
                new Product(){Code=2,Name="Laptop",Description="7 Gen ",Supplier="Lenovo",Price=80000 },
                new Product(){Code=3,Name="Scooter",Description="Electric ",Supplier="TVS",Price=120000 }
            };

        [HttpGet]
        public IActionResult Index()
        {
            // query method
            /**
            var searchbysupplier = from p in productList
                                   where p.Supplier == "Lenovo"
                                   select p;
            **/
            // method syntax 
            var searchbysupplier = productList.Where(p => p.Supplier == "Lenovo");

            return View(searchbysupplier);
            
        }

        
    }
}
