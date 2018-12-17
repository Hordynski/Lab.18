using System;
using System.Collections.Generic;
using System.Linq;

namespace AHBC.Lab._18
{
	public static class LinkedListExtensions
	{
		public static bool RemoveAt<T>(this LinkedList<T> list, int index)
		{
			// James -- These are some serious comments my dude... if you want to keep this logic around, just 
			// create a new branch and leave it there, then you can just switch between the two branches, one with logic, one without.

			//var boolValue = true;

			//for (int i = 0; i < list.Count; i++)
			//{
			//    if (i == index)
			//    {
			//        list.Remove(list.ElementAt(index));
			//        boolValue = true;
			//        break;
			//    }

			//    else
			//    {
			//        boolValue = false;
			//    }
			//}

			//return boolValue;

			var boolValue = list.Remove(list.ElementAt(index));

			return boolValue;
		}

		public static void PrintReverse<T>(this LinkedList<T> list)
		{
			for (int i = list.Count - 1; i > -1; i--)
			{
				list.AddLast(list.ElementAt(i));
				list.Remove(list.ElementAt(i));
			}

			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}
	}
}
