using System;
using System.Runtime.CompilerServices;

namespace practice
{
	public class cat
	{
		public void run()
		{
			Console.WriteLine(" cat run executed");
		}
	}
	public class rat
	{
		public void run()
		{
			Console.WriteLine("Rat run executed");
		}
	}
	class user
	{
		public string name { get; set; }
		private string[] emailids = new string[10];
		public string contact { get; set; }
		public string this[int index]
		{
			get { return emailids[index]; }
			set { emailids[index] = value; }
		}
	}

	class employee
	{
		public string name { get; set; }
		public int age { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			//Caller Name Attribute
			logInfo();

			//dynamic object(Run time object)
			cat c = new cat();
			rat r = new rat();
			common(c);
			common(r);

			//tuple
			//var book = new Tuple<string,string,Double>("C# in depth","Manish",250);

			var book = Tuple.Create("C# in depth", "Manish", 250);

			Console.WriteLine("records");
			Console.WriteLine("Title : " + book.Item1);
			Console.WriteLine("Author : " + book.Item2);
			Console.WriteLine("Price : " + book.Item3);

			//Multi argumented (how we pass multiple return arguments)
			var (name, email) = show();
			Console.WriteLine(name + " " + email);

			//indexers
			var user = new user
			{
				[1] = "abhishek@gmail.com",
				[2] = "utakrsh@gmail.com",
				[3] = "test@gmail.com",
				[4] = "test1@gmail.com",
				name = "tsest2@gmail.com",
				contact = "888888888"
			};

			//string interpolation
			string name1 = "Utkarsh";
			var date = DateTime.Now;
			Console.WriteLine("Hello " + name1 + " it is " + date);
			Console.WriteLine("Hello {0} Today is {1}", name1, date);
			Console.WriteLine($"Hello {name1} Today is {date}"); //string interpolation

			//Null Conditional Operators
			employee emp = null;
			string employee = (emp != null) ? emp.name : null;
			Console.WriteLine(employee);

			sum(4, null); //null operator


		}

		static void common(dynamic obj)
		{
			obj.run();
		}

		static void logInfo([CallerMemberName] string methodName = "", [CallerLineNumberAttribute] int linenumber = 0, [CallerFilePath] string filepath = "")
		{
			Console.WriteLine("Welcome to C#");
			Console.WriteLine("Method Name is : " + methodName);
			Console.WriteLine("Line Number : " + linenumber);
			Console.WriteLine("File path : " + filepath);
		}

		static (string name, string email) show()
		{
			return ("mohit", "mohit@gmail.com");
		}

		static void sum(int? x, int? y) //? -> null operator
		{
			Console.WriteLine(x);
			Console.WriteLine(y);
		}
	}
}
