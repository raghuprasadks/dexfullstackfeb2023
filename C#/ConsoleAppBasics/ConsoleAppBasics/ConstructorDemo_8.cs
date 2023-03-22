using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class ConstructorDemo_8
    {
        
        public static void ConstructorDemo()
        {
            // default constructor
            Console.WriteLine("Account default constructor");
            Account act1 = new Account();
            act1.actno = 100;
            act1.name = "Ravi";
            act1.balance = 10000;
            String info = act1.information();
            Console.WriteLine(info);

            Console.WriteLine("Account with parameterized constructor");

            Account act2 = new Account("Kishor", "kishor@gmail.com", "Anna Sali,Chennai");
            int actno = act2.actno;
            Console.WriteLine("account number " + actno);
            int balance = act2.deposit(actno, 10000);
            Console.WriteLine("balance after 10 k deposit " + balance);
            balance = act2.deposit(actno, 20000);
            Console.WriteLine("balance after 20 k deposit " + balance);

        }
    }

    internal class Account
    {
        internal int actno;
        internal String name;
        internal String email;
        internal long mobile;
        internal String adddress;
        internal String idproof;
        internal int balance;

        public Account()
        {
            Console.WriteLine("Default Constructor");
        }

        public Account(String name, String email,String address)
        {           
            this.name = name;
            this.email = email;
            this.adddress = address;
            Random random = new Random();
            this.actno = random.Next(1, 100);
        }

        public int deposit(int actno,int amt)
        {
            this.balance = this.balance + amt;
            return this.balance;
        }

        public String information()
        {
            return $" Act Number : {actno} Name : {name} Balance : {balance}";


        }
    }
}
