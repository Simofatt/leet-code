using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class MergeSortedArray
    {

        //Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
         // Output: [1,2,2,3,5,6]

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var temp = 0;

            var sum = nums1.Concat(nums2);
            LinkedList<int> list = new LinkedList<int>(sum);
        
            for(int i = 0; i < n;i++) list.Remove(0);
           
     
            var node = list.First;

            for (int i = 0; i < m + n; i++)
            {
                nums1[i] = node.Value;
                node = node.Next;
            }
            for (int i = 0; i < m + n; i++)
            {

                for (int j = i + 1; j < m+n; j++) {

                    if (nums1[i] > nums1[j])
                    {
                        temp = nums1[i];
                        nums1[i] = nums1[j];
                        nums1[j] = temp;

                    }
            }
            }
            Console.WriteLine($"Le resultat de la concatenation des 2 array : {string.Join(" , " , nums1)}");
        }
    }
}
