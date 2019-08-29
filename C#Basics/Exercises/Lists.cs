using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Lists
    {
        public static void Exercise1()
        {

            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name (nothing to stop): ");
                var message = Console.ReadLine();
                if (message == "")
                {
                    break;
                }
                else
                {
                    names.Add(message);
                }
            }
            if (names.Count == 0)
            {
                Console.WriteLine();
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("{0} likes your post.", names[0]);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            }
            else
            {
                Console.WriteLine("{0}, {1}, and {2} others like your post.", names[0], names[1], names.Count - 2);
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter your name: ");
            var input = Console.ReadLine();
            var array = new char[input.Length];
            for (int i = input.Length; i > 0; i--)
            {
                array[input.Length - i] = input[i - 1];
            }
            var reversed = new string(array);
            Console.WriteLine("Name reversed is {0}", reversed);
        }

        public static void Exercise3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
