using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class Operators_4
    {
        /**
         * Arithmetic operators - +,-,*,/,*
         * */
        public static void demoArithmeticOperator()
        {
            Console.WriteLine("Arithmetic operators");
            int n1 = 100;
            int n2 = 3;
            int result;

            result = n1 + n2;
            Console.WriteLine(n1 + " + " + n2 + "=" + result);
        }

        // Write methods to demonstrate logical and comparision operator
    }

    class TestOperator
    {
        public static void TestOperators()
        {
            Operators_4.demoArithmeticOperator();
        }
    }
}
