using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Graph
{

    // URL  : https://leetcode.com/problems/number-of-islands/?envType=study-plan-v2&envId=top-100-liked
    public static class IslandCount
    {
        static public char[][] grid = new char[][]
        {
            new char[] { '1', '1', '1', '1', '0'}  ,
             new char[] { '1', '1', '0', '1', '0'}  ,
              new char[] { '1', '1', '0', '0', '0'}  ,
               new char[] { '0', '0','0', '0','0' }  ,
        };

       
        public static int NumIslands()
        {
            HashSet<string> visited = new();
            int count = 0;  

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        if(Explore(i, j,visited, grid)) count++ ;
                    }
                }
            }
            return count;
        }


            public  static bool Explore(int line,int col, HashSet<string> visited, char[][] grid)
            {

            if ( line>=grid.Length  || col>= grid[0].Length ) return false;

            if (line < 0  || col < 0)  return false;

            if (grid[line][col] == '0')
            {
                return false;
            }

 
            var nodeVisited = line.ToString() + col.ToString();
                if (!visited.Contains(nodeVisited))
                        {
                            visited.Add(nodeVisited);
                            Explore( line-1, col, visited, grid);
                            Explore( line +1, col, visited, grid);
                            Explore( line, col-1, visited, grid);
                            Explore( line, col + 1, visited, grid);

                return true;
                         }
             
            


            return false; 
        }
    }
}
