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
            //With sorted array of integers write a function that returns a sorted array containing the squares of those integers
            //Ex. [-4, -2, 1, 3] => [1, 4, 9, 16]
            //Ex. [-6, -4, 1, 2, 3, 5] => [1, 4, 9, 16, 25, 36]
            //Ex. [-7, -3, -1, 4, 8, 12] => [1, 9, 16, 49, 64, 144]


            //TEST            
            sortedSquaredArray(new int[]{ -4, -2, 1, 3 });
            sortedSquaredArray(new int[] { -6, -4, 1, 2, 3, 5 });
            sortedSquaredArray(new int[] { -7, -3, -1, 4, 8, 12 });
            Console.ReadLine();
        }


        //O(N) Solution
        public static int[] sortedSquaredArray(int[] sortedArray)
        {
            //Initialize fixed array and counter index
            int[] resultArray = new int[sortedArray.Length];
            int leftIndex = 0;
            int rightIndex = sortedArray.Length - 1;

            for (int i = sortedArray.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(sortedArray[leftIndex]) > Math.Abs(sortedArray[rightIndex]))
                {
                    resultArray[i] = Math.Abs(sortedArray[leftIndex]) * Math.Abs(sortedArray[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    resultArray[i] = Math.Abs(sortedArray[rightIndex]) * Math.Abs(sortedArray[rightIndex]);
                    rightIndex--;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", resultArray));
            return resultArray;
        }