﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    internal class DictionaryDemo_17
    {
        public static void demoDictionary()
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding key/value using the Add() method
            numberNames.Add(3, "Three");
            numberNames.Add(2, "Two");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
            {"UK","London, Manchester, Birmingham"},
            {"USA","Chicago, New York, Washington"},
            {"India","Mumbai, New Delhi, Pune"}
        };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

        }

    }
}
