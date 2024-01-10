using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Sorting
{
    public static  class stringCompression
    {

        //https://leetcode.com/problems/string-compression/
        public static int Compress(char[] chars)
        {
            HashSet<char> visited = new HashSet<char>(); 
            ArrayList ints = new ArrayList();
            for(var i=0; i<chars.Length; i++)
            {
                var currentChar = chars[i]; 
            

                var count = 1; 
                if (!visited.Contains(currentChar))
                {
                    for (var j = 0; j < chars.Length; j++)
                    {
                        if (i != j)
                        {
                           // if (currentChar == chars[j]) chars[i+1] = count++; 
                        }
                    }
                    visited.Add(currentChar);
                    ints.Add(currentChar);
                    ints.Add(count); 
                }
            }
          
            return ints.Count; 
        }
    }
}
