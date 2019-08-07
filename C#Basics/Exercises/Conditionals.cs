using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Conditionals
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter a Number:");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        
        public static void Exercise2()
        {
            Console.WriteLine("Enter one number:");
            var input1 = Console.ReadLine();
            Console.WriteLine("Enter another number:");
            var input2 = Console.ReadLine();
            var number1 = Convert.ToInt32(input1);
            var number2 = Convert.ToInt32(input2);
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter the width:");
            var input1 = Console.ReadLine();
            var width = Convert.ToInt32(input1);
            Console.WriteLine("Enter the height");
            var input2 = Console.ReadLine();
            var height = Convert.ToInt32(input2);
            var orientation = (height > width) ? "Portrait" : "Landscape";
            Console.WriteLine("The orientation is " + orientation);
        }

        public static void Exercise4()
        {
            Console.WriteLine("Enter the speed limit:");
            var input1 = Console.ReadLine();
            var speed_limit = Convert.ToInt32(input1);
            Console.WriteLine("Enter the speed of the car:");
            var input2 = Console.ReadLine();
            var car_speed = Convert.ToInt32(input2);
            if (car_speed <= speed_limit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (car_speed - speed_limit) / kmPerDemeritPoint;
                if(demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit Points: " + demeritPoints);
            }
        }
    }
}
