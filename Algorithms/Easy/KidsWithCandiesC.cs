using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Strings
{
    public static class KidsWithCandiesC
    {
        // url https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/?envType=study-plan-v2&envId=leetcode-75
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> result = new List<bool>();
          
            var count = 0;

            for(var i =0; i < candies.Length;i ++)
            {
                var cand = candies[i] +extraCandies; 
                for(var j=0; j < candies.Length;j ++)
                {
                    if(i!=j)
                    {
                        if (cand >= candies[j]) count++; 
                    }
                }
                if (count == candies.Length-1) result.Add(true);
                else result.Add(false); 
                count = 0; 
            }
            return result; 
        }
    }
}

