using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Top100
{
    public static class GenerateParentheses
    {


        public static IList<string> GenerateParenthesis2(int n)
        {
            IList<string> res = new List<string>();
            helper(res, "(", 1, 0, n);
            return res;
        }
        public static void helper(IList<string> res, string curr, int open, int close, int n)
        {
            if (curr.Length == 2 * n)
            {
                res.Add(curr);
                return;
            }
            if (open < n)
            {
                helper(res, curr + "(", open + 1, close, n);
            }
            if (close <open)
            {
                helper(res, curr + ")", open, close + 1, n);
            }
        }
    }

}
