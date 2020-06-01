using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // With array of numbers (not sorted) and a number of sum, write a function that finds the longest subarray within the array
            // Return left and right bounds of the subarray, if there is no sum found return {-1}
            // Ex. intArray = {1, 2, 4, 7, 6}, sum = 13, result = {2, 4}
            
            //TEST            
            findLongestSubarrayBySum(new int[] { 1, 2, 4, 7, 6 }, 13);
            findLongestSubarrayBySum(new int[] { 1, 2, 3, 4, 0, 0, 0, 6, 7, 8, 9, 10 }, 15);
            findLongestSubarrayBySum(new int[] { 1, 3 }, 4);
            Console.ReadLine();
        }

        // O(N) solution, Window Sliding Technique
        public static int[] findLongestSubarrayBySum(int[] intArray, int sum)
        {
            int[] result = { -1 };
            int leftIndex = 0;
            int rightIndex = 0;
            int currentSum = 0;

            while (rightIndex < intArray.Length)
            {
                
                currentSum += intArray[rightIndex];
                while (leftIndex < rightIndex && currentSum > sum)
                {
                    
                    currentSum -= intArray[leftIndex];
                    leftIndex++;
                }
                if (currentSum == sum && (result.Length == 1 || (result[1] - result[0] - 1 < rightIndex - leftIndex)))
                {
                    result = new int[] { leftIndex + 1, rightIndex + 1 };
                }
                rightIndex++;
            }
            Console.WriteLine("[{0}]", string.Join(", ", result));
            return result;
        }