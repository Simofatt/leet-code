using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class WinnerOfAnArrayGame
    {
         
        public static int GetWinner(int[] arr , int k)
        {

            var consecutiveWins = 0;
            var currentWinner = arr[0]; 
            for(var i = 0; i< arr.Length; i++)
            {
                if (arr[i] > currentWinner)
                { 
                    consecutiveWins=1;
                    currentWinner = arr[i]; 
                }else
                {
                    consecutiveWins++;
                }
                if (consecutiveWins == k) break;
            }

            return currentWinner ; 
        }







        //Options 2 Faster : 

        public static int[] GetWinner2(int[] arr, int k)
        {
            LinkedList<int> list = new LinkedList<int>(arr);
            for (var count = 0; count < k; count++)
            {
               
                    if (list.First.Value > list.First.Next.Value)
                    {
                        list.AddLast(list.First.Next.Value);
                        list.Remove(list.First.Next.Value);
                        count++;
                    }else
                {
                    list.AddLast(list.First.Value);
                    list.Remove(list.First.Value);
                    count++;
                }
                }
            

            return new[] { 1 }; 
        }
    }

  
}
