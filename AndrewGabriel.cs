using System;

namespace labAssing
{
    class Program
    {
        static void Main(string[] args)
        {
           CheckForPrimeNumber();
           lessThanOrGreaterThan();

        }
         public static void CheckForPrimeNumber()
        {
            Console.WriteLine("INput a number");
            string input1 =  Console.ReadLine();
            int number = Convert.ToInt32(input1);
            int count = 0;
            for(int i = 1; i <= number; i++){
                if(number % i == 0)
                count++;
            }
             if(count == 2){
                    Console.WriteLine($"{number} is a prime Number");
                }else{
                    Console.WriteLine($"{number} is not a prime Number");
                }
        }
        public static void lessThanOrGreaterThan()
        {
            Console.WriteLine("Welcome here you can check if 2 numbers\nis Lesser than 100.\nWhich will return True of False.");
            Console.WriteLine("Write your first Number");
            string num1 = Console.ReadLine();
            Console.WriteLine("Write your Second Number");
            string num2 = Console.ReadLine();
          
            int number;
            int number2;

            if(int.TryParse(num1, out number) && int.TryParse(num2, out number2))
            {
               int firstNumber = Convert.ToInt32(num1);
                int secondNumber = Convert.ToInt32(num2);
                var result = firstNumber + secondNumber;
                if(result < 100)
                {
                    Console.WriteLine($"{true} {result} is lesser than 100.");
                }
                else
                {
                    Console.WriteLine($"{false} {result} is greater than 100");
                }
            }
            else 
            {
                Console.WriteLine("please input a valid input !!!");
            }
        }
    }
}
