using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Top100
{
    public static  class CombinationSum
    {
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {

            IList<IList<int>> outputs = new List<IList<int>>();
            IList<int> output = new List<int>();
            reccursive(outputs, target,candidates,0,output);
            return outputs;

        }


        public static void reccursive(IList<IList<int>> outputs, int target, int[]candidates,int sum, IList<int> output)
        {

            /*Input: candidates = [2,3,6,7], target = 7
               Output: [[2,2,3],[7]] */

            
            if (sum > target)
            {
                outputs.Add(output);
            }
            else {


                for (var i = 0; i < candidates.Length; i++)
                {

                    sum += candidates[i];



                    if (sum == target)
                    {

                        output.Add(candidates[i]);
                        ;//outputs.Add(output);
                    }
                    else
                    {
                        IList<int> NewOutput = new List<int>();
                        NewOutput.Add(candidates[i]);
                        reccursive(outputs, target, candidates, sum,NewOutput);
                    }

                }
                
            }
        }
    }
}
