using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Sorting
{
    public class BinarySearch
    {

        //https://leetcode.com/problems/binary-search/submissions/
        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {

                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] <= target)
                {

                    start = start + 1;

                }
                else
                {
                    end = end - 1;

                }

            }
            return -1;
        }

        //https://leetcode.com/problems/find-smallest-letter-greater-than-target/submissions/
        public static char NextGreatestLetter(char[] letters, char target)
        {

            int start = 0;
            int end = letters.Length - 1;

            while (start <= end)
            {


                int mid = start + (end - start / 2);

                if (letters[mid] <= target)
                {

                    start = start + 1;
                }
                else
                {
                    end = end - 1;

                }
            }

            char output = start < letters.Length ? letters[start] : letters[0];
            return output;

        }
    }
}
