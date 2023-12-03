using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    internal class PalindromePartitionSoluion
    {
        public IList<IList<string>> Partition(string s)
        {
            IList<IList<IList<string>>> answers = new List<IList<IList<string>>>();
            answers[0] = new List<IList<string>>();
           
            return answers[answers.Count - 1];
        }
    }
}
