using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class ArrayDemo_9
    {
        public static void arrayDemo()
        {
            int[] marks = { 5, 4, 8, 9, 2, 8 };

            Console.WriteLine("Looping through array");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

            marks[0] = 8;
            Console.WriteLine("After update");
            foreach (var mark in marks)
            {
                Console.WriteLine(mark);
            }

            Console.WriteLine("LINQ methods:Max "+marks.Max());
            Console.WriteLine("LINQ methods:Min "+marks.Min());
            Console.WriteLine("LINQ methods:Sum " + marks.Sum());
            Console.WriteLine("LINQ methods:Average " + marks.Average());

            int[] nums = { 10, 15, 16, 8, 6 };

            Console.WriteLine("Original Array");

            foreach (var element in nums)
                Console.WriteLine(element);

            Array.Sort(nums);

            Console.WriteLine("Sorted Array");

            foreach (var element in nums)
                Console.WriteLine(element);

            Array.Reverse(nums);

            Console.WriteLine("Reversed Array");
            Array.ForEach<int>(nums, n => Console.WriteLine(n));
            Console.WriteLine(Array.BinarySearch(nums, 15));
        }
    }
}
