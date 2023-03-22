using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class EncapsulationDemo_13
    {
        internal void encapsulationDemo()
        {
            Customer cust1 = new Customer();
            cust1.setCode(1);
            Console.WriteLine("code :   " + cust1.getCode());

            cust1.name = "ravi";
            Console.WriteLine("name :   " + cust1.name);

            cust1.email = "ravi@gmail.com";
            Console.WriteLine("email :   " + cust1.email);


        }
    }

    internal class Customer
    {
        private int code;

        public void setCode(int code)
        {
            this.code = code;
        }

        public int getCode()
        {
            return this.code;
        }
        //prop tab tab
        public string name { get; set; }
        public string email { get; set; }
        public int zipcode { get; set; }
    }
}
