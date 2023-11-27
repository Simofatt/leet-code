using LeetCode.Algorithms;
using LeetCode.Algorithms.Graph;
using LeetCode.Algorithms.Maths;
using LeetCode.Algorithms.Sorting;
using LeetCode.Algorithms.Strings;
using LeetCode.Algorithms.Top100;
using LeetCode.Algorithms.WindowSliding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

using System.Text;
using System.Threading.Tasks;

namespace LeetCode {
    class Program {
        public static void Main(string[] args)
        {

            //LINKED LIST : [2,1,3,5,4,6,7]

            var array =  WinnerOfAnArrayGame.GetWinner(new[] { 1, 25, 35, 42, 68, 70},1); 
            Console.WriteLine(string.Join(" , " , array));


            MergeSortedArray.Merge(new[] { 1, 2, 3, 0, 0, 0 },3, new[] { 2, 5, 6 } ,3);


            //TWO SUM 
            int[] nums = { 0, 4, 3, 0 };
            int target = 0;
            int[] result = TwoSum.TwoSumm(nums, target);
            Console.WriteLine("result : ");
            foreach (var i in result) { Console.WriteLine(i); }



            //LenghtOfTheLongestSubString
            var s = "ohomm";
            int result2 = LenghtOfTheLongestSubString.LengthOfLongestSubstring(s);
            Console.WriteLine(result2);



            //Adding an item in the end of the list.
            List<int> result3 = new List<int>() { 1, 2, 3, 5 };

            foreach (var i in result3)
            {
                if (i == 2)
                {
                    result3.Remove(i);
                    result3.Add(i);
                    break;
                }
            }
            result3.Select(i => { Console.WriteLine(i); return i; }).ToList();





            //triplet count 
            var arr = new[] { 1, 2, 3, 5 };
            Console.WriteLine("Triplet : " + CountTriplets.countGoodTriplets(arr, 7, 2, 3));


            //REMOVE ELEMENTS 
          
            RemoveElement.RemoveElements();


            // REMOVE DUPLICATES 
            RemoveDuplicates.RemoveDuplicates2();

            //LETTER COMBINATION
            LetterCombinations.LetterCombinationsM("23");

           //GENERATE PARENHESES

            GenerateParentheses.GenerateParenthesis2(3);

            //COMBINATION SUM :
            var arr3 = new[] { 2, 3, 6, 7 };
            CombinationSum.CombinationSum2(arr3,7);

            //PERMUTATIONS
            Permutations.Permute(new[] {1,2,3});

            //SUBSET
            Subsets.Subsets2(new[] {1,2,3});

            FindLargest.LargestNumber(new[] { 8308, 8308, 830 });
            


            //GRAPH HAS PATH ; 
            bool resultHasPath =HasPath.DepthFirstRecu('f', 'k');
            Console.WriteLine($"has path : {resultHasPath}");

            // UNDIRECTED PATH : 
            UndirectedPath.UndirectedPathFunc('j', 'm');


            //CONNECTED COMPONENETS COUNT 
           Console.WriteLine( "THERE IS : "+ConnectedComponentsCount.ConnectedCountFunc()+" COMPONNENTS" );


            Console.WriteLine("THE LARGEST COMPONENT HAS : " + LargestComponenet.LargestComponentFunc() + "NODES");

            Console.WriteLine("The shortest path is : "+ ShortestPath.Explore('a' ,'e'));


            //Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is,
            //for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i]. 


           
            SmallerThanTheCurr.SmallerNumbersThanCurrent(new[] { 8, 1, 2, 2, 3 } );



            //
            ThreeConsecutiveNumbers.SumOfThree(33);

            //SLIDING WINDOW MAX OF THE  3 CONSECUTIVE NUMBERS
            MaxOfThreeConsecutive.max(new[] { 8, 1, 2, 2, 3 });


            //FIND LONGEST SUBSTRING 
            LongestSubstring.Substring("abcdefa");


            // ISLAND COUNT 
            IslandCount.NumIslands();

            ReverseString.ReverseWords("a good  example");
            KidsWithCandiesC.KidsWithCandies(new[] {1,2,3,5} , 3);
            Console.ReadKey();
        }


    }
}