using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class Loops_6
    {

        public static void demoLoops()
        {
            Console.WriteLine("While loop to print 2's table");
            int start = 2;
            int end = 20;
            while (start <= end)
            {
                Console.WriteLine(start);
                start = start + 2;
            }

            Console.WriteLine("For loop to print 5's table");

            for (int i = 5; i <= 50; i = i + 5)
            {
                Console.WriteLine(i);
            }
        }
    }
}
