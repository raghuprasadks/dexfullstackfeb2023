using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class MethodOverload_11
    {       
        public static void demoMethodOverload()
        {
            MethodOverload methodOverLoad = new MethodOverload();
            int result = methodOverLoad.add(100, 200);
            Console.WriteLine("Overload :result " + result);
        }
        
    }

    internal class MethodOverload
    {

        public int add(int n1, int n2)
        {
            return n1 + n2;
        }

        public long add(long n1, long n2)
        {
            return n1 + n2;
        }

        public float add(float n1, float n2)
        {
            return n1 + n2;
        }

    }

}
