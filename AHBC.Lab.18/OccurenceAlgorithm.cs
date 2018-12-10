using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHBC.Lab._18
{
    class OccurenceAlgorithm
    {
        //public static int[] CountOccurences(int[] intArray)
        //{
        //int[] internalArray = new int[intArray.Length];

        //for (int i = 0; i < intArray.Length; i++)
        //{
        //    if (internalArray[i] == intArray[i])
        //    {
        //        var temp = intArray[i];
        //        internalArray[temp];
        //    }

        //    else if (internalArray[i] != intArray[i])
        //    {
        //        internalArray[i] = intArray[i];
        //    }
        //}
        // }

        public static void ArrayFrequency(int[] intArray)
        {
            int big = intArray.Max();

            int[] frequencyArray = new int[big + 1];

            for (int i = 0; i < frequencyArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[j] == i)
                    {
                        frequencyArray[i]++;
                    }
                }
            }
            for (int i = 0; i < frequencyArray.Length; i++)
            {
                if (frequencyArray[i] > 0)
                {
                    Console.WriteLine($"[{i}]: {frequencyArray[i]}");
                }
            }
        }
    }
}
