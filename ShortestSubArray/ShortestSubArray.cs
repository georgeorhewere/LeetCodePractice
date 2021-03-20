using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodePractice
{
    public class ShortestSubArray
    {

        public int FindLengthOfShortestSubarray(int[] arr)
        {
            var sortedList = arr.OrderBy(x => x);
            if (sortedList.SequenceEqual(arr))
            {
                Console.WriteLine($"Already in non decreasing format");
                return 0;
            }
            else
            {
                Console.WriteLine($"Check for  shortest sub array");
                var lastItemInSorted = sortedList.Last();
                int startIndex = 0;
                
                var listSorted = arr.TakeWhile(x => {
                    int currentValueIndex = arr.ToList().IndexOf(x);
                    int nextPos = currentValueIndex + 1 <= arr.Length - 1 ? currentValueIndex + 1 : arr.Length - 1;
                    return arr[currentValueIndex] < arr[nextPos];
                });
                listSorted.ToList().ForEach(f => Console.Write($" {f}"));
                return 1;
            }


          


            // Console.WriteLine($"Has Non decreasing values { isNonDecreasing.ToString() } current check {currentValue}");
            


            
        }
    }
}
