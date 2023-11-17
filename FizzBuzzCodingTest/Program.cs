using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    public class FizzBuzz
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();

            //lopp through the numbers calling the reusable function each time 
            foreach (var number in numbers)
            {
                string result = FindFizzBuzz(number);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        //Function to find if the value is divisible by 3, 5 or both
        public static string FindFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else
            {
                return "test";
            }
        }
    }
}