using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Graph
{
    public static  class ShortestPath
    {

        /*Write a function, shortestPath, that takes in an array of edges for an undirected graph and two nodes (nodeA, nodeB).
         * The function should return the length of the shortest path between A and B. Consider the length as the number of edges
         * in the path, not the number of nodes. If there is no path between A and B, then return -1.
         URL : https://structy.net/problems/shortest-path
         */

        static char[][] edges = new char[][]
        {
            new char[] {'a','c'} ,
            new char[] {'c','b'} ,
            new char[] {'c','d'} ,
            new char[] {'b','d'} ,
            new char[] {'e','d'} ,
            new char[] {'g','f'} ,

    
        };
        static Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>(); 
        static HashSet<char> visited = new HashSet<char>();   
    
     
        
        public static int Explore (char nodeA,char nodeB)
        {
            graph = toGraph(edges);
         

                int path = ShortestPathFunc(nodeA, nodeB);
               
               
          
           
            return path; 
        }

      
            
            public static int ShortestPathFunc(char nodeA,char nodeB)
        {

          


            Queue<string[]> queue = new Queue<string[]>();
            queue.Enqueue(new[] { nodeA.ToString(), "0" });
            visited.Add(nodeA);
            var count = 0;


           
            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
               

                var distance = Int32.Parse(current[1]);
                count = distance +1;






                if (current[0][0] == nodeB)
                {
                    return Int32.Parse(current[1]);
                }


                
                    foreach (var neighboor in graph[current[0][0]])
                    
                    {
                    if (!visited.Contains(neighboor))
                    {
                        
                        visited.Add(neighboor);
                        queue.Enqueue(new[] { neighboor.ToString(), count.ToString() });
                    }
                      
                    }
                }
            

        
         
            return -1;

        }
       


        public static Dictionary<char, List<char>> toGraph (char[][] edges)
        {

            Dictionary<char, List<char>>graph = new Dictionary<char, List<char>> ();

            foreach(var item in edges)
            {
                var to = item[1];
                var from = item[0];
               
                    if(!graph.ContainsKey(from)) graph[from] = new List<char> ();
                    if (!graph.ContainsKey(to)) graph[to] = new List<char>();
              
                graph[from].Add(to);
                graph[to].Add(from);

            }

            return graph;


        }
    }
}
