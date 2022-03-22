using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter first number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth number:");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth number:");
            int number5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sixth number:");
            int number6 = int.Parse(Console.ReadLine());
            int[] arrOfNumbers = { number1, number2, number3, number4, number5, number6 };
            int sum = 0;
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                if (arrOfNumbers[i] % 2 == 0)
                {
                    sum += arrOfNumbers[i];
                }
            }
            Console.WriteLine("Sum of evens is " + sum);
            Console.ReadLine();
            //////////////////////////////////////////////////////////////////
        }
    }
}
