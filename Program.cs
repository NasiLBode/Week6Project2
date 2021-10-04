/* File Name: Week6project2
 * Programmer: Nasi Bode
 * Problem Statement: Create a program that will reverse the contents of an array
 * using methods. There should be three methods (one to create array, one to reverse 
 * the array, and one to print the array)
 * Overall Plan: 
 * 1. Create method to generate an array
 * 2. Fill an array of 10 numbers with random numbers
 * 3. Return array in method
 * 4. In main method, use GenerateNumbers method to create a new array
 * 5. Create method to print array to the screen
 * 6. In main method, invoke PrintNumbers method to check the build of the original array
 * 7. Create Reverse method
 * 8. In Reverse method, find the length of the original array
 * 9. Create a new array to hold the reversed order of the original array
 * 10. using a for loop, place the reversed int values in the new array
 * 11. In main method, print the reversed array to the screen

*/

using System;

namespace Week6Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //invoke the method to create an array
            int[] numbers = GenerateNumbers(arr: new int[10]);
            //print the original array
            Console.WriteLine("This is the original Array");
            PrintNumbers(numbers);

            //invoke the Reversed method to reverse the order of the array
            Reverse(numbers);
            //print reversed array to screen
            Console.WriteLine("\nThis is the reversed Array");
            PrintNumbers(numbers);
        }

        //method to create an array
        static int[] GenerateNumbers(int[] arr)
        {
            //array is the initialized to 10 values
            int[] array = new int[10];
            //Random will generate random numbers to fill array
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                //random numbers will only be between 0 and 100
                array[i] = random.Next(0,100);
            }
            //return array value
            return array;
        }

        //method to reverse the order of the array
        public static void Reverse(int[] array) {
            //find the length of original array
            int reverseArray = array.Length;
            //create new reversed array 
            int[] newReverse = new int[reverseArray];

            for (int i = 0; i < reverseArray; i++)
            {
                //find the values of the numbers to swap
                newReverse[reverseArray - 1 - i] = array[i];
            }
            for (int i = 0; i < reverseArray; i++)
            {
                //swap values into the new array
                array[i] = newReverse[i];
            }

        }
       
        //method to print array to the screen
        static void PrintNumbers(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write("[{0}] ", i);
            }
        }

    }
}
