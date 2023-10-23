using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class IsPalindromeSolution
    {
        public bool isPalindrome(int x)
        {
            string numAsString = x.ToString();
            char[] chars = numAsString.ToCharArray();
            Array.Reverse(chars);
            string reverse = new string(chars);
            if (numAsString.Equals(reverse))
            {
                return true;
            }
            return false;
        }
    }
}
