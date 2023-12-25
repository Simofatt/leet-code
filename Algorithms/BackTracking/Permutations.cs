using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Top100
{
    public static class Permutations
    {

        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> outputs = new List<IList<int>>();
            IList<int> candidates = new List<int>();
            HashSet<int> used = new HashSet<int>();   

            Recursive(outputs, nums,candidates,used);


            return outputs;

        }

        /*Input: nums = [1,2,3]
          Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]] */

        public static void Recursive(IList<IList<int>> outputs, int[] nums, IList<int> candidates, HashSet<int> used)
        {

              if (nums.Length <= candidates.Count)
            {

                outputs.Add(candidates.ToArray());
               
                return;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {

                    if (!used.Contains(i))
                    {
                        
                        candidates.Add(nums[i]);
                        used.Add(i);
                        Recursive(outputs, nums, candidates, used);
                        used.Remove(i);
                        candidates.RemoveAt(candidates.Count - 1);
                        

                    }
                }

            }

        }

    }
}
