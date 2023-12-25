using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.WindowSliding
{
    public static class LongestSubstring
    {
        // abacda 
        //Given a string s, find the length of the longest 
        // substring  without repeating characters.
        //URL :https://leetcode.com/problems/longest-substring-without-repeating-characters/

       


        public static int Substring(string s)
        {
            if(s== null || s.Length == 0) return 0;

            HashSet<int> result = new HashSet<int>();

            var left = 0;
            var max = 0;
            var right = 0;

            while(right < s.Length) {
                char current  = s[right];

                while(result.Contains(current) )
                {
                    result.Remove(s[left]); 
                    left++;
                }

                result.Add(current);
                right++;
              
                max = Math.Max(max, result.Count);
                

              
            } 
           
                if(left ==0)
            {
                max = Math.Max(max, result.Count);
            }
            return max; 

        }
    }
}
