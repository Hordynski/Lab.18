using System;
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
