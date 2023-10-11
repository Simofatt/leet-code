using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

using System.Text;
using System.Threading.Tasks;

namespace LeetCode {
    class Program {
        public static void Main(string[] args)
        {

            //LINKED LIST : [2,1,3,5,4,6,7]

            var array =  WinnerOfAnArrayGame.GetWinner(new[] { 1, 25, 35, 42, 68, 70},1); 
            Console.WriteLine(string.Join(" , " , array));


            MergeSortedArray.Merge(new[] { 1, 2, 3, 0, 0, 0 },3, new[] { 2, 5, 6 } ,3);








            Console.ReadKey();
        }
    }
}