using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP
{
    internal class PrimeNumber
    {

    public void PrimeNumbers() {
            Console.WriteLine("Enter a list of numbers separated by spaces:");
            string input = Console.ReadLine();

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            foreach (int number in numbers)
            {
                bool isPrime = number > 1;
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"{number} is Prime");
                }
                else
                {
                    Console.WriteLine($"{number} is Not Prime");
                }
            }
        }
    }
}
