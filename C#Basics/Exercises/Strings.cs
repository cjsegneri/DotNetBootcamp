using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Strings
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter numbers seperated by hyphens: ");
            var input = Console.ReadLine();
            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            numbers.Sort();
            var isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter a few numbers seperated by a hyphen: ");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var uniques = new List<int>();
            var includeDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
                else
                {
                    includeDuplicates = true;
                    break;
                }
            }

            if (includeDuplicates)
                Console.WriteLine("Duplicate");
        }
    }
}
