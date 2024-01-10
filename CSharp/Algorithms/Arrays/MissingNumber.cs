using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Arrays
{
    public class MissingNumber
    {
        //https://leetcode.com/problems/missing-number/
        //Input: nums = [0,1]
        //Output: 2
        public int MissingNumbers(int[] nums)
        {

            var range = nums.Length; 

            Array.Sort(nums);
           
            for(var i = 0;i<range; i++)
            {
                
                if (nums[i] !=i)
                {
                    return i;
                }
                
            }

            return range; 


        }

      
    }
}
