﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHBC.Lab._18
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> intList = new LinkedList<int>();

            intList.AddFirst(1);
            intList.AddFirst(2);
            intList.AddFirst(3);
            intList.AddFirst(4);
            intList.AddFirst(5);

            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("break");
            Console.WriteLine(" ");

            Console.WriteLine(intList.RemoveAt(3));

            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}