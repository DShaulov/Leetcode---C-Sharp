using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            bool allDigitsNine = true;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 9)
                {
                    allDigitsNine = false;
                }
            }
            if (allDigitsNine)
            {
                int[] answer = new int[digits.Length + 1];
                answer[0] = 1;
                for (int i = 1; i < answer.Length; i++)
                {
                    answer[i] = 0;  
                }
                return answer;
            }
            else
            {
                int[] answer = new int[digits.Length];
                Array.Copy(digits, answer, digits.Length);
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (answer[i] != 9)
                    {
                        answer[i] = answer[i] + 1;
                        break;
                    }
                    else
                    {
                        answer[i] = 0;
                    }
                }
                return answer;
            }

        }
    }
}
