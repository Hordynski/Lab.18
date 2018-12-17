using System;
using System.Collections.Generic;

namespace AHBC.Lab._18
{
	class Program
	{
		static void Main(string[] args)
		{
			// James - I like how you are testing this stuff.
			LinkedList<string> strList = new LinkedList<string>();

			strList.AddFirst("a");
			strList.AddFirst("B");
			strList.AddFirst("C");
			strList.AddFirst("D");
			strList.AddFirst("E");

			foreach (var item in strList)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(" ");
			Console.WriteLine("break");
			Console.WriteLine(" ");

			Console.WriteLine(strList.RemoveAt(0));

			foreach (var item in strList)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine(" ");
			Console.WriteLine("BREAK");
			Console.WriteLine(" ");

			strList.PrintReverse();

			Console.ReadKey();
		}
	}
}
