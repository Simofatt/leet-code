using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Arrays
{
    public static class TwoSum
    {
       

        public static int[] TwoSumm(int[] nums, int target)
        {

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {

                    if (i != j)
                    {
                        var sum = nums[i] + nums[j];
                        if (sum == target)
                        {
                            return new[] { i, j };
                        }
                    }
                }

            }



            return new[] { 0 };

        }
    }
}
