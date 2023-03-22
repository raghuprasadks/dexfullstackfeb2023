using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class CustomExceptionDemo_17
    {

        public static void demoException()
        {

                Student newStudent = null;

                try
                {
                    newStudent = new Student();
                    newStudent.StudentName = "James2341@";

                    ValidateStudent(newStudent);
                }
                catch (InvalidStudentNameException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

        

        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);

        }
    }

    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    [Serializable]
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }
    }

}
