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
            int currentValue = 0;
            bool isNonDecreasing = false;
            arr.ToList().ForEach(x =>
            {
                isNonDecreasing = x > currentValue;
                if (isNonDecreasing)
                {
                    Console.WriteLine($"fail value {x}");
                    return;
                }
                    

                currentValue = x;
            });

            Console.WriteLine($"Has Non decreasing values { isNonDecreasing.ToString() } current check {currentValue}");
            


            return 0;
        }
    }
}
