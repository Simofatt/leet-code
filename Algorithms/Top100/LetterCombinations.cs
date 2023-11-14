using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Top100
{
    public static class LetterCombinations
    {
        static Dictionary<char, char[]> keypad = new Dictionary<char, char[]> {{'2', new char[]{'a', 'b', 'c'}},
    {'3', new char[]{'d', 'e', 'f'}}, {'4', new char[] {'g', 'h', 'i'}},
    {'5', new char[] {'j', 'k', 'l'}}, {'6', new char[] {'m', 'n', 'o'}},
    {'7', new char[] {'p', 'q', 'r', 's'}}, {'8', new char[] {'t', 'u', 'v'}},
    {'9', new char[] {'w', 'x', 'y', 'z'}}};


        static Dictionary<char, string[]> dic = new Dictionary<char, string[]>()
            {

                {'2',new[]{"a","b","c" } } ,
                {'3',new[]{"d","e","f" } } ,
                {'4',new[]{"g","h","i" } } ,
                {'5',new[]{"j","k","l" } } ,
                {'6',new[]{"m","n","o" } } ,
                {'7',new[]{"p","q","r","s" } } ,
                {'8',new[]{"t","u","v" } } ,
                {'9',new[]{"w","x","y","z" } } ,

            };
        public static IList<string> LetterCombinationsM(string digits)
        {

         
            IList<string> AllCombins = new List<string>();
            combins(digits,0,"",AllCombins);
            return AllCombins;


 

        }

        public static void combins(string digits,int j,string current,IList<string> AllCombins)
        {

            if (digits.Length <= j)
            {
                if (!current.Equals("")) AllCombins.Add(current);


            }
            else
            {

                string[] values = dic[digits[j]];

                for (var i = 0; i < values.Length; i++)
                {
                    var newCurrent = current + values[i];


                    combins(digits, j + 1, newCurrent, AllCombins);
                }

            }
        }











        public static void AddCombination2(string curr, string digits, int index, IList<string> list)
        {
            if (index >= digits.Length) list.Add(curr);
            else
            {
                char[] map = keypad[digits[index]];

                for (int i = 0; i < map.Length; i++)
                {
                    string newCurr = curr + map[i];

                    AddCombination2(newCurr, digits, index + 1, list);
                }
            }
        }

        public static IList<string> LetterCombinations2(string digits)
        {
            IList<string> combinations = new List<string>();

            if (digits.Length > 0) AddCombination2("", digits, 0, combinations);

            return combinations;
        }
    }
}

  





