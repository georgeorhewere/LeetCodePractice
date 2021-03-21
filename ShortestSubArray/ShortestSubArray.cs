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
                int currentValueIndex = 0;                
                int skip = 0;
                int nextSeriesValue = 0;
                bool checkCompleted = false;
                List<int> sortedArray = new List<int>();


                while (currentValueIndex < arr.Length -1)
                {

                    var listSorted = arr.Skip(skip).TakeWhile(x =>
                    {
                        currentValueIndex = arr.ToList().IndexOf(x);
                        int nextPos = currentValueIndex + 1 <= arr.Length - 1 ? currentValueIndex + 1 : arr.Length - 1;
                        Console.WriteLine($"Current value on { arr[currentValueIndex] } skip: { skip }");
                        int valeToCheck = sortedArray.Any() ? sortedArray.Last() : arr[currentValueIndex];


                        if (arr[currentValueIndex] < arr[nextPos])
                        {
                           // if(!sortedArray.Contains(valeToCheck))
                                sortedArray.Add(arr[currentValueIndex]);
                            return true;
                        }
                        else
                        {
                            skip = currentValueIndex + 1;                            
                            return false;
                        }
                    }).ToList();
                    // listSorted.ToList().ForEach(f => Console.Write($" {f}"));
                    sortedArray.ForEach(f => Console.Write($" {f}"));
                }

                

                return 1;
            }


          


            // Console.WriteLine($"Has Non decreasing values { isNonDecreasing.ToString() } current check {currentValue}");
            


            
        }
    }
}
