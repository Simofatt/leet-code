using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Arrays
{
    public class MajElements
    {
        //nums = [2,2,1,1,1,2,2] 
        //2

        //https://leetcode.com/problems/majority-element/description/?envType=study-plan-v2&envId=top-interview-150
        public int MajorityElement(int[] nums)
        {
            Dictionary < int,int> keyValuePairs = new Dictionary<int,int>();
            int majoelement = nums[0];
            int max = 0 ; 


         for(var i=0; i<nums.Length;i++)
            {
                if (!keyValuePairs.ContainsKey(nums[i]) )
                {
                    keyValuePairs.Add(nums[i],0);
                    
                }else
                {
                    keyValuePairs.TryGetValue(nums[i],out var value);
                    value++;
                    keyValuePairs[nums[i]] = value; 
                }
            
            }

         foreach(var key in keyValuePairs)
            {
                if(key.Value > max  )
                {
                    max = key.Value;  
                    majoelement = key.Key;
                }
                
            }
          
            
            return majoelement ; 
        }
    
}
}
