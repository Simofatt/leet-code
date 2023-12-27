using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeetCode.Algorithms.Graph
{
    public static class FindLargest
    {

        static Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();
        static HashSet<string> visited = new HashSet<string>();
        static List<string> findLargest = new List<string>();
        static string curr = "";


        public static string LargestNumber(int[] nums)
        {

            List<int> candidate = new List<int>();
            HashSet<int> visited = new HashSet<int>();
            List<List<int>> output = new();
            List<string> ints = new();

            recurssive(nums, candidate, visited, output);


            foreach (var item in output)
            {
                ints.Add(string.Join("", item));
            }
            Console.Write("");
            ints.Sort();

            return ints[ints.Count - 1].ToString();
        }

        public static void recurssive(int[] nums, List<int> candidate, HashSet<int> visited, List<List<int>> output)
        {

            /*[10,2,0]  */


            //
            if (nums.Length == candidate.Count) output.Add(candidate.ToList());


            for (var i = 0; i < nums.Length; i++)
            {

                if (!visited.Contains(i))
                {
                    visited.Add(i);
                    candidate.Add(nums[i]);
                    recurssive(nums, candidate, visited, output);
                    visited.Remove(i);
                    candidate.RemoveAt(candidate.Count - 1);
                }
            }












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
