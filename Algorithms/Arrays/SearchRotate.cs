using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Arrays
{
    public class SearchRotate
    {

        // https://leetcode.com/problems/search-in-rotated-sorted-array/
        //nums = [0,1,2,4,5,6,7], target = 3
        // Output: 4,5,6,7,0,1,2  => 7


        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int temp = 0;
            int end = target; 
            

           for(int i=end; i < nums.Length; i++) {

                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end++;
               
            }
           
         for(var i=0; i < nums.Length;i++)
            {
                if (nums[i] ==target)
                {
                    return i;
                }
            }

            return -1;
        }

       
    }

}
