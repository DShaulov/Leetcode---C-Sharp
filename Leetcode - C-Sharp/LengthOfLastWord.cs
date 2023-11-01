using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class LengthOfLastWordSolution
    {
        public int LengthOfLastWord(string s)
        {
            int length = 0;
            bool firstLetterSeen = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (firstLetterSeen)
                    {
                        return length;
                    }
                    continue;
                }
                else
                {
                    firstLetterSeen = true;
                    length++;
                }
            }
            return length;
        }
    }
}
