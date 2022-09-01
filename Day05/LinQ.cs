using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class LinQ
    {
        public static void IntroLinq()
        {
            int[] numbers = new int[] { 98, 99, 200, 95, 200, 98, 94, 80, 2014 };
            // sum from 98 to 2019
            var sum = numbers.Sum(x => x++);
            Console.WriteLine($"Sum : {sum}");

            var min = numbers.Min();
            Console.WriteLine($"Min : {min}");

            var max = numbers.Max();
            Console.WriteLine($"Max : {max}");

            var duplicatest = numbers.Distinct();
            foreach (var item in duplicatest)
            {
                Console.WriteLine(item);
            }
        }
    }
}
