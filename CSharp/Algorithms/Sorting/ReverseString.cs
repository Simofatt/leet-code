using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Sorting
{
    public static  class ReverseString
    {

        // https://leetcode.com/problems/reverse-words-in-a-string/?envType=study-plan-v2&envId=leetcode-75
        public static string ReverseWords(string s)
        {

            string[] words = s.Split(' ');
            var reverseWord = ""; 

            var WordCount = words.Length;
            for(var i=1; i<=words.Length; i++)
            {
                if(words[WordCount - i] != "")
                   reverseWord +=  words[WordCount-i] + " " ;
            }
          
            

            
            return reverseWord.Trim(); 
        }
    }
}
