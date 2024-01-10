using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.WindowSliding
{
    public static  class MaxOfThreeConsecutive
    {
        // { 8, 1, 2, 2, 3 } 
        //RETURN THE MAXIMUM OF 3 CONSECUTIVES NUMBERS 
        //USING SLIDING WINDOW ALGO 
        public static int max(int[] nums)
        {


            var index = 0;
        
            int [] ThreeNums = new int[3];
            var max = 0;
            var currSum = 0; 


            while (index+2 < nums.Length)
            {
                
                for (int i = index; i < index + 3; i++)
                {
                    ThreeNums[i - index] = nums[i];
                }

                currSum = ThreeNums.Sum();
                if (currSum > max) max = currSum; 
                index++;
            }

            return max;
        }  
    }
}
