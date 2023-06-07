using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleTasks
{
    internal class BreakContinue
    {
        //Create a program, which will ask user to enter a number, if number will be negative exit the loop
        public static void Task1()
        {
            int input = 0;
            while(true)
            {
                Console.Write("Please enter a number: ");
                input = Int32.Parse(Console.ReadLine());
                if (input < 0)
                {
                    Console.WriteLine("Number is negative. Aborting...");
                    break;
                }

                Console.WriteLine("Moving on");

            }
        }

        //Create a program which will print all number from 1 to 10 except 3 and 7 using continue keyword
        public static void Task2()
        {
            for(int i = 1; i <= 10; i++)
            {
                if(i == 3 || i == 7)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
