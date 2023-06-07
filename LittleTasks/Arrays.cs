using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleTasks
{
    internal class Arrays
    {
        //Write a program that calculates and prints the sum of all elements in array of integers
        public static void Task1()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //Create a program that finds and displays the average value of all elements in an array of floating-point numbers
        public static void Task2()
        {
            float[] array = new float[5] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };

            float arraySum = 0;
            foreach (var number in array)
            {
                arraySum += number;
            }

            Console.WriteLine(arraySum / 2);
        }

        //Find max value in an array with numbers
        //(Optional) find second max element
        public static void Task3()
        {
            double[] array = new double[10] { 1.0, 2.0, 3.0, 4.0, 5.0, 
                Random.Shared.NextDouble() * 10.0, Random.Shared.NextDouble() * 10.0, Random.Shared.NextDouble() * 10.0, 
                Random.Shared.NextDouble() * 10.0, Random.Shared.NextDouble() * 10.0 };

            double maxNumber = Double.MinValue;
            double otherMaxNumber = Double.MinValue;
            foreach(var number in array)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            //
            foreach(var number in array)
            {
                if (number > otherMaxNumber && number < maxNumber)
                {
                    otherMaxNumber = number;
                }
            }

            Console.WriteLine($"Max value in array is: ${maxNumber}");
            Console.WriteLine($"Other Max value in array is: ${otherMaxNumber}");
        }

        //(optional) sort an integer array with any algorithm of sorting
        public static void Task4_Hacky()
        {
            int[] unsortedArray = new int[10] {Random.Shared.Next(20), Random.Shared.Next(20), Random.Shared.Next(20), Random.Shared.Next(20), Random.Shared.Next(20),
            Random.Shared.Next(20),Random.Shared.Next(20),Random.Shared.Next(20),Random.Shared.Next(20),Random.Shared.Next(20)};

            foreach (var element in unsortedArray)
            {
                Console.Write($"{element}, ");
            }


            Console.Write(" -> ");
            //This is dirty hack for the task
            Array.Sort(unsortedArray);

            foreach(var element in unsortedArray) 
            {
                Console.Write($"{element}, ");
            }

            Console.Write(System.Environment.NewLine);
        }

        //(optional) sort an integer array with any algorithm of sorting
        public static void Task4_Bubble()
        {
            int[] unsortedArray = new int[10] {Random.Shared.Next(20), Random.Shared.Next(20), Random.Shared.Next(20), Random.Shared.Next(20), Random.Shared.Next(20),
            Random.Shared.Next(20),Random.Shared.Next(20),Random.Shared.Next(20),Random.Shared.Next(20),Random.Shared.Next(20)};

            foreach (var element in unsortedArray)
            {
                Console.Write($"{element}, ");
            }

            Console.Write(" -> ");
            //Bubble sort
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                for(int j = i; j < unsortedArray.Length; j++)
                {
                    if (unsortedArray[i] > unsortedArray[j])
                    {
                        int temporaryHold = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[j];
                        unsortedArray[j] = temporaryHold;
                    }
                }

            }

            foreach (var element in unsortedArray)
            {
                Console.Write($"{element}, ");
            }

            Console.Write(System.Environment.NewLine);
        }
    }
}