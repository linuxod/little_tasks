using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleTasks
{
    internal class For
    {
        //Print numbers from 1 to 10 using a for loop (using foreach loop)
        public static void Task1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            foreach (var i in Enumerable.Range(1, 10))
            {
                Console.WriteLine(i);
            }
        }

        //Calculate the sum of numbers using a for loop
        public static void Task2() 
        {
            int sum = 0;
            for (int i = 1; i <= 100 ; i++) 
            { 
                sum += i;
            }

            Console.WriteLine(sum);
        }

        //Calculate the factorial of a given number using a for loop
        public static void Task3()
        {
            int number = Random.Shared.Next(10) + 1; //Random from 1 to 11

            int factorial = 1;
            for(int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial for {number} is {factorial}");
        }

        //(Optional) Print all numbers from 20 to 0 with step 2 ( 20, 18, 16, 16)
        public static void Task4()
        {
            for(int i = 20; i >= 0; i -=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
