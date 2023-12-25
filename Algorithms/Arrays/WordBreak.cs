using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Arrays
{
    public  class WordBreak
    {
        public static bool WordBreaks(string s, IList<string> wordDict)
        {
            Dictionary<string, bool> memo = new();
            HashSet<string> dict = new HashSet<string>(wordDict);
            return DFS(s, memo, dict); 
            
        }

        public static bool DFS(string s, Dictionary<string,bool> memo,HashSet<string> dict)
        {
            if(memo.ContainsKey(s)) { return memo[s]; }
            if (dict.Contains(s)) return true;
            var word = ""; 
            for(var i= 0;i<s.Length;i++)
            {
                word = s.Substring(0, i);
                if (dict.Contains(word) && DFS(s.Substring(i), memo, dict))
                {
                    memo[s] = true;
                     return true; 

                }
            }
            memo[s] = false;

            return false;

        }


























            /*  public static bool WordBreaks(string s, IList<string> wordDict)
            {
               var wordD = "";
               foreach(var item in wordDict)
                {
                    wordD += item;
                }
               if(wordD == s) { return true; }
                var word = "";
                var j = 0; 
                for(var i=j; i <s.Length;i++)
                {
                    word += s[i];

                    foreach (var item in wordDict)
                    {

                        if (item == word)
                        {
                            j = i+1;
                            word = "";
                            break;
                        }

                    }

                }
                if (j >=s.Length) return true;


                return false;

            }*/
        }
}
