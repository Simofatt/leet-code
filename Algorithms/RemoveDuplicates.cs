using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class RemoveDuplicates
    {

        public static int RemoveDuplicates2()
        {
            var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

           Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
            var count = 0;
            foreach(var item in nums ) {
                if (!keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs.Add(item, item);
                    count++;  
                }
            }
          
            var uniqueValues = keyValuePairs.Values.ToArray();
            Array.Copy(uniqueValues, nums, uniqueValues.Length);

            Console.WriteLine("");
            Console.WriteLine("****************************** Remove Duplicates********************");
            Console.WriteLine(string.Join(" , ", nums)); 
            
           

            return count;
        }

      
        }
    
}
