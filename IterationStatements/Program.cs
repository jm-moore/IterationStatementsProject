using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            int num = 0;

            do
            {
                num++;
                numbers.Add(num);

            } while (num < 100); 


            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }

            Console.WriteLine("Increase:");

            foreach(var integer in numbers)
            {
                Console.WriteLine(integer);
            }
             
            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
