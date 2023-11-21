using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Graph
{
    public static class HasPath
    {


        /*Write a function, hasPath, that takes in an object representing the adjacency list of a directed
         * acyclic graph and two nodes (src, dst). The function should return a boolean indicating whether
         * or not there exists a directed path between the source and destination nodes. */

        static Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>
        {
            { 'f', new List<char> { 'g', 'i' } },
            { 'g', new List<char> { 'h' } },
            { 'h', new List<char>() },
            { 'i', new List<char> { 'g','k' } },
            { 'j', new List<char> {'i' } },
            { 'k', new List<char>() }
        };


        //DFT : FILO
        public static bool DepthFirstPrint(char source, char dest)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(source); 

            while(stack.Count> 0) {
                    
                var current = stack.Pop();
                if(current == dest)
                {
                    return true; 
                }

                foreach(var neighboor in graph[current]) {

                    stack.Push( neighboor);
                
                }
            }
            return false;
        }

        //DFT :RECURSIVE 
        
        public static bool DepthFirstRecu(char source, char dest)
        {

            if(source == dest)
            {
                return true;
            }

            foreach(var neighboor in graph[source])
            {
                if(DepthFirstRecu(neighboor, dest)) return true;

            }
            return false; 
        }


        //BFT :  FIFO
        public static bool BreathFirstSolution(char source , char dest)
        {

            Queue <char> queue = new Queue<char>();
            queue.Enqueue(source);


            while(queue.Count > 0) {

               char current =  queue.Dequeue();
                if(current == dest) return true;
                foreach (var neighboor in graph[current]) { 
                

                    queue.Enqueue(neighboor);
                }
            
            }


            return false; 
        }

    }
}
