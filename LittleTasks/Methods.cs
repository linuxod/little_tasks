using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleTasks
{
    internal class Methods
    {
        //Write a method that takes two integers as parameters and returns the maximum of two
        public static int Task1(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            return y;
        }

        //Implement a method that calculates the factorial of a given number. THe method should take an integer as a parameter and return the factorial value
        public static int Task2(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;

        }

        //Implement a method that takes an array of integers as a parameter and returns the sum of all the elements in array
        public static int Task3(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }

            return sum;
        }

        //(Optional) write a method which will accept 3 marameters -> sides of a triangle and will return Boolean value if this triangle can exists or not
        public static bool Task4(int sideA, int sideB, int sideC)
        {
            //Triangle Inequality Theorem: sum of two side lengths of a triangle is always greater than the third side

            return sideA + sideB > sideC || sideA + sideC > sideB || sideB + sideC > sideA;

        }
    }
}
