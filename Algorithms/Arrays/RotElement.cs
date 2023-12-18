using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Arrays
{

    //Input: nums = [1,2,3,4,5,6,7], k = 3  
    //Output: [5,6,7,1,2,3,4] 
    // 7 . 2 3 4 5 6
   
 
    public class RotElement
    {

        public static void Rotate(int[] nums, int k)
        {
            var temp = 0;
            var indexOfElement = nums.Length -1;
            var tempJ = 0;
            
          
            for(int i = 0; i < nums.Length; i++)
            {
                if (k == i) { break; }
                temp = nums[i];
                var elementToMove=  nums[indexOfElement];
                nums[i] = elementToMove;

                for (int j = nums.Length-1; j>i; j--)
                {
                    indexOfElement--;
                    tempJ = nums[indexOfElement];
                    nums[j] = tempJ; 
                }
                nums[i+1] = temp;
                indexOfElement = nums.Length - 1;
               

              







            }
           
        }

    }
}
