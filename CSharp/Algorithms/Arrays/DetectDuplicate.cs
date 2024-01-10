using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Arrays
{
    public class DetectDuplicate
    {
        public static bool duplicate(int[] nums)
        {
            HashSet<int> duplicates = new();
            foreach(var item in nums)
            {
                if(!duplicates.Contains(item))
                {
                   duplicates.Add(item);
                }else
                {
                    return true;
                }

            }
            return false;
        }
    }
}
