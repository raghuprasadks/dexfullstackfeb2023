using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetmvcbasics.Models
{
    public class Product
    {
        
        public int Code { get; set; }
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
        public int Price { get; set; }
    }
}
