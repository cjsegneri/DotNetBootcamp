using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Loops
    {
        public static void Exercise1()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine("Numbers divisible by three between 1 and 100: " + count);
        }

        public static void Exercise2()
        {
            var message = "Enter a number, or OK to stop: ";
            Console.WriteLine(message);
            var input1 = Console.ReadLine();
            var numSum = 0;
            while (input1 != "OK")
            {
                var num = Convert.ToInt32(input1);
                numSum += num;

                Console.WriteLine(message);
                input1 = Console.ReadLine();
            }
            Console.WriteLine("The total sum is: " + numSum);
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter a number to compute the fractorial for: ");
            var input1 = Console.ReadLine();
            var num = Convert.ToInt32(input1);
            long factorial = (long)num;
            for (int i = num-1; i > 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("The factorial is: " + factorial);
        }

        public static void Exercise4()
        {
            var number = new Random().Next(1, 10);
            Console.WriteLine("Number is: {0}", number);

            for (int i = 4; i >= 1; i--)
            {
                Console.WriteLine("{0} chance(s) left to guess the number: ", i);
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("You Won!");
                    break;
                }
                else if (i == 1)
                {
                    Console.WriteLine("Out of guesses, you lost!");
                }
            }
        }

        public static void Exercise5()
        {
            Console.WriteLine("This program finds the largest number in a list.");
            Console.WriteLine("Enter a list of numbers seperated by commas:");
            var input = Console.ReadLine();

            var numbers = input.Split(',');
            var maxNum = Convert.ToInt32(numbers[0]);
            foreach (var charNum in numbers)
            {
                var num = Convert.ToInt32(charNum);
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            Console.WriteLine("Max number in {0} is {1}", input, maxNum);
        }
    }
}
