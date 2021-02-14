
namespace ProgrammingChallengesCsharp
{
    public static class BinarySearch
    {
        public static object BinarySearchIterative(int[] arrayNumbers, int target)
        {
            int minValue = 0;
            int maxValue = arrayNumbers.Length - 1;
            while (minValue <= maxValue)
            {
                int midElement = (minValue + maxValue) / 2;
                if (target == arrayNumbers[midElement])
                {
                    return ++midElement;
                }
                else if (target < arrayNumbers[midElement])
                {
                    maxValue = midElement - 1;
                }
                else
                {
                    minValue = midElement + 1;
                }
            }
            return "Nil";
        }
    }
}
