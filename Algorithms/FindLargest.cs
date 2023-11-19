using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class FindLargest
    {

        public static string LargestNumber(int[] nums)
        {

            List<string> outputs = new List<string>();
            HashSet<int> used = new HashSet<int> ();
            var strings = nums.Select(x => x.ToString()).ToList();

            
            
           
            recurssive( strings,outputs,"",0,used);
            List<int> integers = outputs.Select(x => Int32.Parse(x)).ToList();

            integers.Sort();
            return integers[integers.Count -1].ToString();
            }

        public static void recurssive( List<string> strings, List<string> result,string curr,int index,HashSet<int> used)
        {

            /*[3,30,34,5,9]*/
            if (curr.Length== strings.Count)
            {

                result.Add(curr);
                return;
            }

            for (int i = 0; i < strings.Count; i++)
            {

                if (!used.Contains(i))
                {
                    curr = curr + strings[i];
                    used.Add(i);
                    recurssive(strings, result, curr, index + 1, used);
                    curr = "";
                    used.Remove(i);

                }
            }
        }
    }
}
