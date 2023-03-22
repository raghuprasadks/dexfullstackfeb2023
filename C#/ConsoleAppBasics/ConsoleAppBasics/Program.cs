using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Console.WriteLine("Hello World.Welcome to C#");

            //  Datatypes_2.dataTypesDemo();

            // Calculator_3 calci = new Calculator_3();
            // calci.add(100, 200);
            // int result=calci.multiply(10, 20);
            // Console.WriteLine("multiplication " + result);

            //TestOperator.TestOperators();
            // UserInputs_5.demoUserInput();
            // Loops_6.demoLoops();
            // ConstructorDemo_8.ConstructorDemo();
            //ArrayDemo_9.arrayDemo();
            //InheritanceDemo_10.demoInheritance();
            //MethodOverload_11.demoMethodOverload();
            // InterfaceDemo_12.TestInterface();

            // EncapsulationDemo_13 ecDemo = new EncapsulationDemo_13();
            // ecDemo.encapsulationDemo();

            //  GenericsDemo_14 genericDemo = new GenericsDemo_14();
            // genericDemo.GenericsDemo();

            // ArrayListDemo_15.demoArrayList();
            // ListDemo_15.demoList1();

            //ListDemo_15.demoList2();

            //  DictionaryDemo_17.demoDictionary();

            //CustomExceptionDemo_17.demoException();

            // CoronaTest_19 coronaTest = new CoronaTest_19();
            // coronaTest.testCorona();

            //  DelegateDemo_20 delegateDemo = new DelegateDemo_20();
            //delegateDemo.delegateTest();

            //delegateDemo.anonymousMethod();

            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();


            Console.ReadKey();
        }

        // event handler
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}

    public delegate void Notify();  // delegate

    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted();
        }


        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }

