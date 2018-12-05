using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHBC.Lab._18
{
    public static class LinkedListExtensions
    {
        public static bool RemoveAt<T>(this LinkedList<T> list, int index)
        {
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
