using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Strings
{
    public class CountOccurence
    {

        public static  void count (string s , int k )
        {

            Dictionary<char, int> CharCount = new();

            foreach(var item in s.ToLower())
            {
                if(!CharCount.ContainsKey(item))
                {
                    CharCount.Add(item, 1); 

                }else
                {
                    CharCount[item]++;  
                }
            }
        

            for(int i= 0;i<k;i++)
            {
                var item = CharCount.OrderByDescending(x => x.Value).FirstOrDefault();
                CharCount.Remove(item.Key);


                Console.WriteLine($"Character is {item.Key} count is : {item.Value} ");

            }
          
           
        }
    }
}
