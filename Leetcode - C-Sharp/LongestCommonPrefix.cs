using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int shortestStringLength = 200;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < shortestStringLength)
                {
                    shortestStringLength = strs[i].Length;
                }
            }
            string longestCommonPrefix = "";
            for (int i = 0; i < shortestStringLength; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[0][i] != strs[j][i])
                    {
                        return longestCommonPrefix;
                    }
                }
                longestCommonPrefix += strs[0][i];
            }
            return longestCommonPrefix;
        }
    }
}
