using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    delegate void MyDelegate(String msg);

    internal class DelegateDemo_20
    {
        public void delegateTest()
        {
            // A.methodA(" with out delegate");
            // B.methodB("with out delegate");
            MyDelegate delegateref1 = A.methodA;
            delegateref1("msg from delegate");
            MyDelegate delegateref2 = B.methodB;
            delegateref2.Invoke("msg from delegate using invoke");
            // Multicast delegate
            MyDelegate del = delegateref1 + delegateref2; // combines del1 + del2
            del("Hello World:: multicast");
        }

        public void anonymousMethod()
        {
            // MyDelegate mydelegate = A.methodA;
            MyDelegate mydelegate = delegate (String msg)
            {
                Console.WriteLine("delegate to call anonymousMethod with msg " + msg);

            };

            mydelegate("Msg from anonymous method");
        }

    }

    internal class A
    {

        public static void methodA(String msg)
        {
            Console.WriteLine("Class A:method A : msg " + msg);
        }
    }

    internal class B
    {

        public static void methodB(String msg)
        {
            Console.WriteLine("Class B:method B : msg " + msg);
        }
    }
}
