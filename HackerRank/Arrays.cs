using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class Arrays
    {
        public static void RunArrays()
        {
            //SINGLE DIMENSION ARRAYS

            //1. Declaration of arrays --------------------------------------------------------------------------------------

            int[] numbers = new int[5]; //- All elements in this array will be 0 [0,0,0,0,0]
            int[] primeNumbers = { 2, 3, 5, 7, 11 }; //Predefined declaration of arrays
            string[] colors = new string[] {"Red", "Blue", "Green"}; // string array. Create and initialise


            //2. Access and modify elements ---------------------------------------------------------------------------------
            int[] scores = { 85, 70, 98 };
            //Console.WriteLine($"Unmodified: {string.Join(" ,", scores)}");

            //modify the array
            scores[1] = 95;
            //Console.WriteLine($"Modified: {string.Join(" ,", scores)}");

            //3. Looping through arrays -------------------------------------------------------------------------------------
            int[] temperatures = { 23, 25, 19, 22 };
            
            //for loop
            for (int i = 0; i < temperatures.Length; i++)
            {
                //Console.WriteLine(temperatures[i]);
            }

            //foreach loop
            foreach(int temp in temperatures)
            {
                //Console.WriteLine(temp);
            }

            //4. Array Methods and Operations --------------------------------------------------------------------------------

            int[] methodOps = { 5, 8, 3, 1, 9, 6 }; //Common array
            
            //a. Sorting
            Array.Sort(methodOps); //Sorts in ascending order
            //Console.WriteLine($"Sorting Result: {string.Join(" ,", methodOps)}");

            //b. Reverse
            Array.Reverse(methodOps); //Reverses the array but no sorting done before.
            //Console.WriteLine($"Reverse Result: {string.Join(" ,", methodOps)}");

            //c. Searching
            int[] primes = { 2, 11, 3, 5, 7};
            int index = Array.IndexOf(primes, 7); // This method searches for the second arg in the first arg which is an array
            //Console.WriteLine($"Index or position of number in the array: {index}");

            //For binary search, requires a sorted array
            Array.Sort(primes);
            int binaryIndex = Array.BinarySearch(primes, 7); // Same as IndexOf but for Binary Search, Array must be sorted first. Output is 3 if sorted, else works same like IndexOf
            //Console.WriteLine($"Binary Search output: {binaryIndex}");

            //5. Copying Arrays ----------------------------------------------------------------------------------------------
            int[] source = { 1, 2, 3, 4 };
            int[] destination = new int[4];
            Array.Copy(source, destination, source.Length); //Copies everything
            Array.ConstrainedCopy(source, 1, destination, 2, 2); // COpies range. Output is [0 0 2 3]

            //6. Resizing ----------------------------------------------------------------------------------------------------
            Array.Resize(ref source, 7); // Output will be [1 2 3 4 0 0 0]




            //MULTIDIMENSION ARRAYS
            //1. Rectangular Arrays ------------------------------------------------------------------------------------------
            int[,] matrix = new int[2, 3];




        }

        public static void Task1()
        {
            //Question - Create an array of 5 strings (e.g., names) and modify the third element. Print the array before and after the change.


            string[] arr = { "Monday", "Tuesday", "Wed", "Thursday", "Friday" };
            Console.WriteLine($"Unmodified array: {string.Join(", ", arr)}");

            //Modify the array
            arr[2] = "Wednesday";
            Console.WriteLine($"Modified array: {string.Join(", ", arr)}");

        }

        public static void Task2()
        {
            //Question - Create an array of integers, sort it, reverse it, and find the index of a specific value. Print the results after each operation.
            int[] arr = { 3, 6, 7, 1, 0, 9, 4 };
            Console.WriteLine($"Original array: {string.Join(", ", arr)}");

            Array.Sort(arr);
            Console.WriteLine($"Sorted array: {string.Join(", ", arr)}");

            Array.Reverse(arr);
            Console.WriteLine($"Reversed array: {string.Join(", ", arr)}");

            int position = Array.IndexOf(arr, 7);
            Console.WriteLine($"Index of 7 is : {position}");

        }

        public static void Task3()
        {
            //Question - Create a jagged array with 3 rows of different lengths. Print each row and calculate the total number of elements.
            int[][] jaggedArray = new int[3][];
            jaggedArray[0]= new int[]{1, 3, 5};
            jaggedArray[1]= new int[]{2, 4, 6, 8};
            jaggedArray[2] = new int[] { 7, 9, 11, 13 };

            //Print each row
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Row {i}: Value: {string.Join(", ", jaggedArray[i])}");
            }

            //Calculate total number of elements
            int counter = 0;

            foreach (int[] subArray in jaggedArray)
            {
                counter += subArray.Length;
            }

            Console.WriteLine($"Count of elements: {counter}");
        }

        public static void ReverseArrayManually()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }

            Console.WriteLine($"Reversed Array: {string.Join(", ", array)}");

        }

        public static void FindDuplicates()
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            Array.Sort( array ); // Sort the array first

            Console.WriteLine("Duplicate items in the array and their count:");
            for (int i = 0; i < array.Length;  i++)
            {
                int count = 1;
                while (i < array.Length - 1 && array[i] == array[i + 1])
                {
                    count++;
                    i++; // Move to next duplicate
                }
                if (count > 1 ) Console.WriteLine($"Element {array[i]} occurs {count} times");
            }

        }

        public static void MatrixMultiplication()
        {
            int[,] matrix1 =
            {
                {1, 3, 5 },
                {7, 9, 11 }
            };

            int[,] matrix2 =
            {
                {2, 4, 6 },
                {8, 10, 12 }
            };

            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            int[,] finalMatrix = new int[rows, cols];


            for (int i = 0; i < rows; i++) //starting by rows of matrix 1
            {
                for (int j = 0; j < cols; j++) // Columns of matrix 1
                {
                    finalMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }

            Console.WriteLine("Final Result:");
            for(int i = 0; i < rows; i++)
            {
                for ( int j = 0; j < cols; ++j )
                {
                    Console.Write(finalMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }



        }

        public static void JaggedArraySum()
        {
            int[][] jaggedArray = new int [3][];
            jaggedArray[0] = new int[]{ 1, 2, 3};
            jaggedArray[1] = new int[] { 4, 5, 6, 7 };
            jaggedArray[2] = new int[] { 8, 9, 10 };


            int sum = 0;

            foreach (int[] subArray in jaggedArray)
            {
                for (int i = 0; i < subArray.Length; i++)
                {
                    sum += subArray[i];
                }
            }

            Console.WriteLine($"Sum of All elements is {sum}");
        }

        /*
         Problem 1: Rotate Array by K Positions
            Description: Given an array of integers and an integer k, rotate the array to the right by k positions. For example, if the array is [1, 2, 3, 4, 5] and k = 2, the result should be [4, 5, 1, 2, 3].

            Tricky Aspect: Handling cases where k is larger than the array length and avoiding unnecessary memory usage.

            Hint:

            > Use the modulo operator (%) to handle cases where k > array.Length.
            > Consider reversing parts of the array: reverse the entire array, then reverse the first k elements, then reverse the rest.
            > Example: For [1, 2, 3, 4, 5] with k = 2, reverse all → [5, 4, 3, 2, 1], reverse first 2 → [4, 5, 3, 2, 1], reverse last 3 → [4, 5, 1, 2, 3].
         */
        public static void RotateArrayByKPositions() 
        {
            int[] array = [1, 2, 3, 4, 5];
            int arrLen = array.Length;
            Console.WriteLine($"Original Array: {string.Join(", ", array)}");
            int k = 2; //Position
            int[] resultArray = new int[arrLen];

            for (int i = 0; i < arrLen; i++)
            {
                int elementIndex = (i + k % arrLen + arrLen) % arrLen; // For first instance , sum will be (0 + 2 + 5) % 5 = 7 % 5 = 2.
                resultArray[elementIndex] = array[i]; //Assign the values to result
            }
            Array.Copy(resultArray, array, arrLen);
            Console.WriteLine($"Final Array: {string.Join(", ", array)}");
        }

        /*
         * Problem 2: Find the Missing Number
            Description: You’re given an array of n-1 integers containing numbers from 1 to n with one number missing. Find the missing number. Example: [1, 2, 4, 5] (n = 5) → missing number is 3.

            Tricky Aspect: Solving it efficiently without sorting or using extra space, and handling edge cases like very large n.

            Hint:

            > The sum of numbers from 1 to n is given by the formula n * (n + 1) / 2.
            > Subtract the sum of the array elements from this to find the missing number.
            > Watch out for integer overflow with large n—use long if needed.
         */
        public static void FindMissingNumber()
        {
            int[] initialArray = [1, 2, 4, 5];
            long n = initialArray.Length + 1;

            int initialSum = 0;

            for(int i = 0; i < initialArray.Length; i++)
            {
                initialSum += initialArray[i];
            }


            var sumOfNumbers = n * (n + 1) / 2;
            var missingNumber  = sumOfNumbers - initialSum;

            Console.WriteLine($"The missing number in the array is {missingNumber}");

        }

        /*
         Problem 3: Maximum Subarray Sum (Kadane’s Algorithm)
            Description: Given an array of integers (positive and negative), find the maximum sum of any contiguous subarray. Example: [-2, 1, -3, 4, -1, 2, 1, -5, 4] → max sum is 6 (subarray [4, -1, 2, 1]).

            Tricky Aspect: Handling all-negative arrays and ensuring the algorithm runs in O(n) time.

            Hint:

            > Use a variable to track the current sum and another for the maximum sum found so far.
            > For each element, decide whether to start a new subarray or add to the current one (reset to 0 if the sum goes negative).
            > Test with edge cases like [-1, -2, -3]—the answer should be the largest single element.
         */
        public static void MaxSubArraySum()
        {
            int[] inputArray = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
            int current = 0;
            int max = inputArray[0];

            for (int i = 0; i < inputArray.Length; i++)
            {
                current+= inputArray[i];
                if (current > max) max = current;

                if (current < 0) current = 0;

            }

            Console.WriteLine($"Maximum sum is : {max}");

        }

        /*
         Problem 4: Merge Two Sorted Arrays Without Extra Space
            Description: Given two sorted arrays arr1 and arr2, merge them into arr1 (which has enough extra space at the end) in sorted order. Example: arr1 = [1, 3, 5, 0, 0, 0] (size 3 used, 3 extra), arr2 = [2, 4, 6], result → arr1 = [1, 2, 3, 4, 5, 6].

            Tricky Aspect: Merging in-place without using additional memory beyond the given arrays.

            Hint:

            > Start from the end of both arrays and work backward, placing the largest elements at the end of arr1.
            > Use three pointers: one for the last used position in arr1, one for the end of arr2, and one for the current position in the merged result.
            > Compare elements and fill arr1 from right to left.
         */
        public static void MergeTwoSortedArraysWithoutSpace()
        {
            int[] arr1 = [1, 3, 5, 0, 0, 0];
            int[] arr2 = [2, 4, 6];
            int m = 3; //Number of actual elements in arr1.
            int n = arr2.Length;

            int p1 = m - 1;
            int p2 = n - 1;
            int p = m + n - 1;

            while (p1 >= 0 && p2 >= 0)
            {
                if (arr1[p1] >  arr2[p2])
                {
                    arr1[p] = arr1[p1];
                    p1--;
                }
                else
                {
                    arr1[p] = arr2[p2];
                    p2--;
                }
                p--;
            }

            if (p2 >= 0)
            {
                arr1[p] = arr2[p2];
                p2--;
                p--;
            }

            Console.WriteLine($"Merged Array: {string.Join(", ", arr1)}");


        }

        /*
         Problem 5: Trapping Rain Water
            Description: Given an array representing the height of bars in a histogram, calculate how much water can be trapped between them after raining. Example: [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1] → 6 units of water.

            Tricky Aspect: Understanding how water is trapped and optimizing the solution to avoid brute force.

            Hint:

            > Water trapped at each index depends on the minimum of the maximum height to the left and right, minus the current height.
            > Precompute two arrays: one for the max height to the left of each index, and one for the max height to the right.
            > For optimization, try a two-pointer approach: start from both ends and move inward, updating the max left and right as you go.
         */

        public static void TappingRainWater() { }
    }
}
