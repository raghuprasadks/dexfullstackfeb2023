using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    internal class GenericsDemo_14
    {

        public void GenericsDemo()
        {
            DataStore<int> datastoreint = new DataStore<int>();
            datastoreint.Data = 100;
            Console.WriteLine("Int as generics : " + datastoreint.Data);
            // datastoreint.Data = "test with string";

            DataStore<string> datastorestr = new DataStore<string>();
            datastorestr.Data = "hundred";
            Console.WriteLine("string as generics : " + datastorestr.Data);          
        }
    }


    internal  class DataStore<T>
    {
        public T Data { get; set; }
    }
}
