using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms.Top100
{
    public static class Subsets
    {
        public static IList<IList<int>> Subsets2(int[] nums)
        {
            IList<IList<int>> outputs = new List<IList<int>>();
            IList<int> candidates = new List<int>();
            recursive(outputs, candidates, nums, 0);

            return outputs;
        }

        /* Input: nums = [1,2,3]
           Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]] */
        public static void recursive(IList<IList<int>> outputs, IList<int> candidates, int[] nums, int index)
        {
            outputs.Add(candidates.ToList()); // Add the current subset to the result

            for (int i = index; i < nums.Length; i++)
            {
                candidates.Add(nums[i]);

                recursive(outputs, candidates, nums, i + 1);

                candidates.RemoveAt(candidates.Count - 1);
            }
        }
    }
}
