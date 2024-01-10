using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Maths
{
    public static class ProductExeptItSelft
    {
        // https://leetcode.com/problems/product-of-array-except-self/?envType=study-plan-v2&envId=leetcode-75

        public static int[] ProductExceptSelf(int[] nums)
        {
           
            int[] result = new int[nums.Length];
            for(var i  =0;i<nums.Length;i++)
            {
                var product = 1;
                for (var j =0 ;j<nums.Length;j++)
                {
                    if (i != j)
                    {

                        product = product * nums[j];
                    }
                }
                result[i] = product;    
                
            }

            return result;
        }
    }
}
