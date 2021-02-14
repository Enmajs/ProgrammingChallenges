using System;
using System.Linq;

namespace ProgrammingChallengesCsharp
{
    public class MergeSortedArrays
    {

        public static void BubbleSort()
        {
            int[] array = { 232, 9, 1, 209, 4, 99, 20, 22, 11 };

            int temp;

            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length -2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            System.Console.WriteLine(String.Join("\n", array));

            Console.ReadLine();
        }

    }
}
