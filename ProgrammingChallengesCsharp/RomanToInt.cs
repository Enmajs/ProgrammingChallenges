using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallengesCsharp
{
    public class RomanToInt
    {
        public int RomanToIntSolution(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i < (s.Length - 1) && map[s[i]] < map[s[i + 1]]) result -= map[s[i]];
                else result += map[s[i]];
            }

            return result;
        }
    }
}
