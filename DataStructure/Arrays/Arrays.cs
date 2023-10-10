using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    public static class ArrayLibrary
    {

        // USING LINQ
        public static int[] SwapArray(int[] arr , int elementToMove)
        {
            var indexOfTheElementToMove = Array.IndexOf(arr, elementToMove);    
            var newArray = arr.Where((value,index) => index !=indexOfTheElementToMove).ToArray();
            newArray = newArray.Concat(new[] {elementToMove}).ToArray(); 
            return newArray ;
        }
        //USING LINKED LIST 
        public static int[] SwapArraysUsingLinkedList(int[] arr, int elementToMove) { 
            
            LinkedList<int> list = new LinkedList<int>(arr);   
            list.AddLast(elementToMove);
            list.Remove(elementToMove);
            
            return list.ToArray();

        
        }
    }
}
