using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy
{
    public static  class PlaceFlowers
    {
        //https://leetcode.com/problems/can-place-flowers/


        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {


            var plot = 0;
            var left = n;

            while (left > 0 && plot < flowerbed.Length)
            {
                if (flowerbed[plot] == 1)
                {
                    plot++;
                }
                else if (flowerbed[plot] == 0 && (plot == 0 || flowerbed[plot - 1] == 0) && (plot >= flowerbed.Length - 1 || flowerbed[plot + 1] == 0))
                {
                    flowerbed[plot] = 1;
                    plot++;
                    left--;
                }

                plot++;
            }

            return left == 0;
        }
    }
}
