using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    internal class ListDemo_15
    {
        internal static void demoList1()
        {
            Console.WriteLine("List Demo");
            List<int> intList = new List<int>();
            intList.Add(10);
            int[] marks = { 20, 19, 18, 23 };
            intList.AddRange(marks);

            foreach (var mark in intList)
            {
                Console.WriteLine(mark);
            }
        }

        internal static void demoList2()
        {
            Console.WriteLine("List Demo  - List of Products");
            List<Product> prodList = new List<Product>();

            Product prod1 = new Product(1, "mobile", "smartphone ", "Vivo", 30000);
            Product prod2 = new Product(2, "laptop", "7Gen laptop ", "Lenovo", 85000);
            Product prod3 = new Product(3, "Headphone", "Boat headphone", "Boat",3000);

            prodList.Add(prod1);
            prodList.Add(prod2);
            prodList.Add(prod3);

            int total = 0;
            int searchprd = 10000;
            foreach(Product prd in prodList)
            {
                //Console.WriteLine(prd.info());

                total = total +prd.Price;

                if (prd.Price> searchprd)
                {
                    Console.WriteLine(prd.info());
                }

            }

            Console.WriteLine("total products price " + total);
        }
    }

    internal class Product {

        public int Code { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Supplier { get; set; }

        public int Price { get; set; }

        public Product(int code,string name,string desc,string supplier,int Price)
        {
            this.Code = code;
            this.Name = name;
            this.Desc = desc;
            this.Supplier = supplier;
            this.Price = Price;
        }

        public string info()
        {
            return "Code : " + this.Code + " Name : " + this.Name + " Supplier : " + this.Supplier + "Price : " + this.Price;
        }
    }

}
