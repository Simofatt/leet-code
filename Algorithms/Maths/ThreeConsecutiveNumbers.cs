using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Maths
{
    public static  class ThreeConsecutiveNumbers
    {
        //Given an integer num, return three consecutive integers
        //(as a sorted array) that sum to num. If num cannot be expressed as the sum of three consecutive integers,
        //return an empty array.
        //URL :https://leetcode.com/problems/find-three-consecutive-integers-that-sum-to-a-given-number/description/



        public static long[] SumOfThree(long num)
        {
            var med = num /3; 

            if((med -1) + med + (med+1) ==num ) return new long[3] { med-1,med,med+1 };

            return new long[0]; 
        }
    }
}
