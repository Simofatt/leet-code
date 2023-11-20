using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Graph
{
    public static class LargestComponenet
    {

        static Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>
        {
            { '0', new List<char> { '8', '1','5' } },
            { '1', new List<char> { '0' } },
            { '5', new List<char> {'0','8' } },
            { '8', new List<char> { '0','5' } },
            { '2', new List<char> {'3','4' } },
            { '3', new List<char> {'2','4' } },
            { '4', new List<char>{'4','2' } }
        };
        static HashSet<char> visited = new HashSet<char>();

        static List<int>  ComponentCount = new List<int>(); 
        public static int LargestComponentFunc()
        {

           
            foreach (var item in graph)
            {
                if (Explore(item.Key))
                {

                 

                    ComponentCount.Add(visited.Count);
                    visited.Clear(); 
                    

                }


            }

            ComponentCount.Sort();
            return ComponentCount[ComponentCount.Count -1];
        }

        public static bool Explore(char current)
        {
            if (visited.Contains(current)) return false;

            visited.Add(current);
            foreach (var neighboor in graph[current])
            {
                Explore(neighboor);

            }


            return true;
        }

    }
}
