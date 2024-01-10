using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Graph
{
    public static  class UndirectedPath
    {

        /*
       * undirected path
           Write a 
          function, undirectedPath, that takes in an array of edges for an undirected graph and two nodes 
          (nodeA, nodeB). The function should return a boolean indicating whether or not there exists a 
          path between nodeA and nodeB.
          public static  class UndirectedPath 
      */

        static List<char[]> edges = new List<char[]>
        {
            new char[] { 'i', 'j' },
            new char[] { 'k', 'i' },
            new char[] { 'm', 'k' },
            new char[] { 'k', 'l' },
            new char[] { 'o', 'n' }
        };


        public static bool UndirectedPathFunc(char nodeA,char nodeB)
        {

            Dictionary<char, List<char>> graph = ToGraph(edges);

            Stack<char> stack = new Stack<char>();  
            HashSet<char> visited = new HashSet<char>();    

            stack.Push(nodeA);

            while (stack.Count > 0) {
               var current = stack.Pop();
             

                   
                if (current == nodeB) return true;

                if (!visited.Contains(current))
                { visited.Add(current); 

                foreach (var neighboor in graph[current])
                {

                    stack.Push(neighboor);
                      
                }
                }
            }
            return false;

        }

   

        public static Dictionary<char,List<char>> ToGraph(List<char[]> edges)
        {

            Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>();    

            foreach (char[] edge in edges)
            {
                char to = edge[0];
                char from = edge[1];    

                //undirected edges 
                if(!graph.ContainsKey(to))  graph[to] = new List<char>();
                if(!graph.ContainsKey(from)) graph[from] = new List<char>();

                graph[from].Add(to);
                graph[to].Add(from);

            }

            return graph;
        }



        /* directed edges 
         * 
                if(!graph.ContainsKey(fril))  graph[from] = new List<char>();
                 graph[to].Add(to);
         * 
         * 
         */
    }
}
