using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallengesCsharp
{
    public class ReverseArray
    {

        public static void ReverseChar(char[] char_array, int n)
        {
            char[] dest_array = new char[n];
            int j = n;
            for (int i = 0; i < n; i++)
            {
                dest_array[j - 1] = char_array[i];
                j = j - 1;
            }

            Console.WriteLine("Reversed array:"); 
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(dest_array[k] + " ");
            }
        }

        public static void ReverseArrayEasy(int[] numbers)
        {

            if (numbers.Length != 0)
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine("reverse " + numbers[i]);
                }
            }
            else
            {
                Console.WriteLine("invalid input!!!");
            }
        }

        public static void PlaceReversal(int[] numbers)
        {
            if (numbers.Length != 0)
            {
                int temp;
                int size = numbers.Length;

                for (int i = 0; i < size / 2; i++)
                {
                    temp = numbers[i];
                    numbers[i] = numbers[size - 1];
                    numbers[size - 1] = temp;
                }
                Console.WriteLine(string.Join("\n", numbers));             
            }
            else
            {
                Console.WriteLine("invalid input!!!");
            }    
        }
    }
}
