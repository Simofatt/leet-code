using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Easy
{
    public static  class PlaceFlowers
    {



        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {


            for(var i = 0; i < flowerbed.Length; i++)
            {

                if(Explore(flowerbed , n,i)) return true;
            }

            return false;
        }

        public static bool Explore(int[] flowerbed, int n,int col) {


            if(col <0 ) return false ;
            if(col> flowerbed.Length ) return false ;
            if(col==0 ) n--;
            if(n ==0 ) return true ;
            Explore(flowerbed, n, col+1);
            Explore(flowerbed, n, col-1);


            return true;
        
        }
    }
}
