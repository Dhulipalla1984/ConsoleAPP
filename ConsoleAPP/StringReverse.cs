using System.Text;
using System;
using ConsoleApp;

namespace ConsoleApp { 

    public class StringReverse
    {
        /* Reverse String * palindrome */
        public string StringReversePalindrome()
        {


            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;
            bool v = false;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];

            }
            if (originalString == reverseString)
            {
                v = true;
                Console.Write(v);

            }
            else
            {
                Console.Write(v);
            }
            Console.Write($"Reverse String is : {reverseString} ");
            // Return the reversed string
            return reverseString;

        }
    }
}


    /* Prime Numbers */

    /*int[] primeNubers = { 1, 2, 3, 4, 5 };
    foreach (int n in primeNubers)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine(n + 1);
        }
        else
        {
            Console.WriteLine("not a prime number");
        }

    }
    public string class StringFunction1() { 
        Console.WriteLine("Enter a string:");
    string input = Console.ReadLine();
        for (int i = 0; i < input.Length; ++i)
        {
            StringBuilder sb = new StringBuilder(input.Length - i);

            for (int j = i; j < input.Length; j++)
            {
                sb.Append(input[j]);
                Console.WriteLine(sb);
            }
            //Console.ReadKey();
        }
    }
    */
    
