using System;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leet Code Exercises!");
            testShortestSubArray();
            Console.ReadKey();
        }

        static  void testShortestSubArray()
        {
            ShortestSubArray manager = new ShortestSubArray();
            int[] testArray = new int[] { 1, 2, 3, 10, 4, 2, 3, 5 };
            int result = manager.FindLengthOfShortestSubarray(testArray);
            Console.WriteLine($"The Length of the shortest subarray is {result}");
            // already sorted
            testArray = new int[] { 1, 2, 3};
            result = manager.FindLengthOfShortestSubarray(testArray);


            Console.WriteLine($"The Length of the shortest subarray is {result}");

        }
    }
}
