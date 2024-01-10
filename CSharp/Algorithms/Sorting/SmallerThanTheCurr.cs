using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Sorting
{
    public static class SmallerThanTheCurr
    {

      //  https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/

        
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {

            int[] result = new int[nums.Length];
         

            var count = 0; 
            for(var i=0; i<nums.Length; i++)
            {
                for(var j=0;j<nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        count++; 


                    }
                }
                result[i] = count;
                count = 0;


            }
                

            return result;  
        }
    }
}
