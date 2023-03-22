using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class Datatypes_2
    {

       internal static void dataTypesDemo()
        {
            string coursename = "Fullstack Webdevelopment using C#";
            int duration = 30;
            float rating = 10.0f;
            long mobile = 9845547471;
            bool ruActive = true;
            char chardemo = 'A';

            Console.WriteLine("Course name is " + coursename);
            Console.WriteLine("Course duration is " + duration);

            var amount = "100";

            Console.WriteLine("data type of amount {0}" ,amount.GetType());

            var str = "Hello World!!";
            Console.WriteLine("Type of str is {0}", str.GetType());

        }

    }
}
