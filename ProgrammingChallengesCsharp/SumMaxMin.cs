using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallengesCsharp
{
    public class SumMaxMin
    {

        /// <summary>
        /// Given five positive integers, find the minimum and maximum values 
        /// that can be calculated by summing exactly four of the five integers. 
        /// Then print the respective minimum and maximum values as a single line of two space-separated 
        /// long integers.
        /// </summary>
        /// <param name="array"></param>
        public static void SumMaxMinArray(int[] arr)
        {
            //example input
            //int[]  input = { 396285104 573261094 759641832 819230764 364801279 };
            //int[]  expected output = 2093989309 2548418794

            int maxArr = arr.Count(), i;
            long sumTemp = 0, sumMin = 0, sumMax = 0;

            for (i = 0; i < maxArr; i++)
            {
                sumTemp += arr[i];
            }
            sumMin = sumTemp - arr.Max();
            sumMax = sumTemp - arr.Min();

            Console.Write(sumMin + " " + sumMax);
            Console.ReadLine();
        }
    }
}
