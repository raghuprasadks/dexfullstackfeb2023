using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    internal class Calculator_3
    {

        internal void add(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Result  of addition is " + result);
        }

        internal int multiply(int num1,int num2)
        {
            return num1 * num2;
        }
    }
}
