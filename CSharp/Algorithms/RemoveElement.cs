using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class RemoveElement
    {
        
        public static int RemoveElements()
        {
           
            var nums = new[] { 3, 2, 2, 3 };
            int val = 3;


            var index = 0;
            var temp = 0; 
            
            for(int i = 0;i<nums.Length;i++)
            {
                if (nums[i] != val)
                {
                    temp = nums[index];
                    nums[index] = nums[i];
                    index++;
                    nums[i] = temp;   
                }
            }

            Console.WriteLine("************************* REMOVE ELEMENTS**********************");
            Console.WriteLine($"Remove element {val} from the beginning of the array {string.Join(" , ", nums)}"); 
            
            return index; 
        }
    }
}
