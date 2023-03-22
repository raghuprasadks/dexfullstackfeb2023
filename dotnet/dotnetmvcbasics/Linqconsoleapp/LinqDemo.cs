using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqconsoleapp
{
	class LinqDemo
	{

		public void LinqDemo1()
		{
			IList<string> stringList = new List<string>() {
			"C# Tutorials",
			"VB.NET Tutorials",
			"Learn C++",
			"MVC Tutorials" ,
			"Java"
		};

			// LINQ Query Syntax
			var result = from s in stringList
						 where s.Contains("Tutorials")
						 select s;

			foreach (var str in result)
			{
				Console.WriteLine(str);
			}
		}
	}
    }

