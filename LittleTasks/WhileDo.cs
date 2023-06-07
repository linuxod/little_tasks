

internal class WhileDo
{

    //Print numbers from 1 to 10 using a while-do loop
    public static void Task1()
    {
        int i = 0;
        while(++i <= 10)
        {
            Console.WriteLine(i);
        }
    }

    //Calculate the sum of numbers from 1 to 100 using a do-while loop
    public static void Task2()
    {
        int sum = 0;
        int addition = 1;

        do
        {
            sum += addition++;
        } while (addition <= 100);

        Console.WriteLine(sum);
    }

    //Print the even numbers from 1 to 20 using a while-do loop
    public static void Task3()
    {
        int number = 0;

        while(number <20)
        {
            number += 2;
            Console.WriteLine(number);
        }    
    }
}
