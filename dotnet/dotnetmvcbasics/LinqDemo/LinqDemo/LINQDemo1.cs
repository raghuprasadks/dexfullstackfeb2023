using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
    class LINQDemo1
    {

        public static void LinqDemo()
        {
            // Data source
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");

        }

        public static void LinqDemoWithObjects()
        {
            Student[] studentArray = {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve", Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill", Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron", Age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris", Age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Rob", Age = 19 } ,
                };

            Console.WriteLine("Display students having Age>12 && Age<20");
            // Use LINQ Method to find teenager students
            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            foreach (var student in teenAgerStudents)
            {
                Console.WriteLine(student.StudentName);
            }
            Console.WriteLine("Display student having Bill as Name");

            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();
            Console.WriteLine("Display student Name " + bill.StudentName);

            Console.WriteLine("Display student having ID 5");

            // Use LINQ to find student whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine("Display student Name having id 5" + student5.StudentName);
            IList<Student> studentList = new List<Student>();

        }

        public static void LinqDemoWithCollections()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;
            Console.WriteLine("Teen age Students:Query syntax");

            foreach (Student std in teenAgerStudent)
            {
                Console.WriteLine(std.StudentName);
            }

            Console.WriteLine("Teen age Students:Method syntax");
            // LINQ Method Syntax to find out teenager students
            var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20)
                                              .ToList<Student>();

            foreach (Student std in teenAgerStudent)
            {
                Console.WriteLine(std.StudentName);
            }
        }

        class Student
        {
            public int StudentID { get; set; }
            public String StudentName { get; set; }
            public int Age { get; set; }
        }

    }
}

