using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleTasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While-do segment tasks");
            WhileDo.Task1();
            WhileDo.Task2();
            WhileDo.Task3();

            Console.WriteLine("For segment tasks");
            For.Task1();
            For.Task2();
            For.Task3();
            For.Task4();

            Console.WriteLine("Break/Continue tasks");
            // BreakContinue.Task1();
            // BreakContinue.Task2();

            Console.WriteLine("Array tasks");
            Arrays.Task1();
            Arrays.Task2();
            Arrays.Task3();
            Arrays.Task4_Hacky();
            Arrays.Task4_Bubble();

            Console.WriteLine("Method tasks");
            Console.WriteLine(Methods.Task1(5, 15));
            Console.WriteLine($"Factorial for 12 is " + Methods.Task2(12));
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Sum for array is " + Methods.Task3(array));

            Console.WriteLine($"Triangle of 4,6,8 can exist: " + Methods.Task4(4, 6, 8));


        }
    }
}
