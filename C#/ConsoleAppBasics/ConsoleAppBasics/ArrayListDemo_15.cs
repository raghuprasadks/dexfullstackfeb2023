using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    internal class ArrayListDemo_15
    {
        internal static void demoArrayList()
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("training");
            al.Add(true);
            al.Add(1.021);

            Console.WriteLine("Before modification");
            foreach ( var elem in al)
            {
                Console.WriteLine(elem);
            }

            al.Insert(0, "One");
            al.Remove("traing");
            Console.WriteLine("After modification");
            foreach (var elem in al)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
