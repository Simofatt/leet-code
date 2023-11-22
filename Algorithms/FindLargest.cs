using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class FindLargest
    {

        static Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();
        static HashSet<string> visited = new HashSet<string>();
        static List<string> findLargest = new List<string>();
        static string curr = "";


        public static string LargestNumber(int[] nums)
        {
            ToGraph(nums);


            foreach (var item in graph)
            { 
                if (recurssive(item.Key, nums))
                {
                    //visited.Remove(item.Key);
                    curr = item.Key;
                    findLargest.Add(curr);
                }
            }



            return "";
        }

        public static bool recurssive(string node, int[] nums)
        {

            /*[10,2,0]  */

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(node);

            //test


            while (queue.Count > 0)
            {
                if (nums.Length == visited.Count+1) return true;

                var deque = queue.Dequeue();
                visited.Remove(node);


                foreach (var neighboor in graph[deque])
                {

                    if (!visited.Contains(neighboor))
                    {
                        visited.Add(neighboor);
                        queue.Enqueue(neighboor);

                    }
                }

            }

            return false;

        }

        public static void ToGraph(int[] nums)
        {


            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {

                    var to = nums[i].ToString();
                    if (!graph.ContainsKey(to)) graph[to] = new List<string>();

                    if (i != j) graph[to].Add(nums[j].ToString());

                }

            }


        }







    }
}
