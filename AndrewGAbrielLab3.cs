using System;

namespace labAssing
{
    class lab3Assignment
    {
           public static void remainder()
        {   
            Console.WriteLine("Welcome\n To get the remainder of any division you want to carry out\n");
            Console.WriteLine("Please input your First Number.");
            string input1 = Console.ReadLine();
            Console.WriteLine("Please input your Second Number.");
            string input2 = Console.ReadLine();

            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            int remainder = num1 % num2;

            Console.WriteLine($"The Remainder of {num1} divided by {num2} = {remainder}.");
        }
    }
}