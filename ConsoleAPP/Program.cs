using ConsoleApp;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ConsoleAPP;
internal class Program
{
    public delegate void petanim(string pet);
    delegate void Greeting(string message);
    static void SayHi(string name)
    {
        Console.WriteLine($"Hi {name}");
    }

    private static void Main(string[] args)
    {

        ArrayProgram multiDimensionalArray = new ArrayProgram();
        multiDimensionalArray.ArrayListExample();
        multiDimensionalArray.HashTableArray();
        multiDimensionalArray.StackArray2();
        LamdaFunctions lamdaFunctions = new LamdaFunctions();
        lamdaFunctions.DivisibleBy();
        var square = (int x) => x * x;
        var result = square(2);
        Console.WriteLine("expression:" + result);

        var mutiply = (int x, int y) =>
        {
            return x * y;

        };
        var result1 = mutiply(5, 6);
        Console.WriteLine(result1);
        var multipliers = new List<Func<int, int>>();

        for (int i = 1; i <= 3; i++)
        {
            int factory = i;
            multipliers.Add((int x) => x * i);
        }

        foreach (var multiplier in multipliers)
        {
            int result2 = multiplier(10);
            Console.WriteLine("Lamda Functions:" + result2);
        }
        Greeting greeting = new Greeting(SayHi);
        greeting.Invoke("John");
        List<LamdaFunctions> details = new List<LamdaFunctions>()
        {
            new LamdaFunctions{rollNumber = 23, name = "keerthi"},
            new LamdaFunctions{rollNumber = 56, name = "satish"}
        };
        var detailsList = details.OrderBy(x => x.name);
        foreach (var value in detailsList)
        {
            Console.WriteLine(value.rollNumber + "," + value.name);
        }
        petanim p = delegate (string mypet)
        {
            Console.WriteLine("My favorite pet is: {0}",
                                                 mypet);
        };
        p("Dog");
        List<int> numerics = new List<int> { 1, 2, 3, 4, 5 };

        // Print elements without using loops
        Console.WriteLine(string.Join(", ", numerics.Select(n => n.ToString())));
        Console.WriteLine("this is test");
        StringReverse stringReversePalindrome = new StringReverse();
        MultiDimensionalArray multiDimensionalArray = new MultiDimensionalArray();
        PrimeNumber primeNumber = new PrimeNumber();
        primeNumber.PrimeNumbers();
        CheckPalindrome checkPalindrome = new CheckPalindrome();
        Console.Write("Enter a string: ");
        string str = Console.ReadLine().Replace(" ", "").ToLower();
        bool IsPalindrome = checkPalindrome.IsPalindrome(str, 0, str.Length - 1);
        if (IsPalindrome)
        {
            Console.WriteLine("Is palindrome");

        }
        else
        {
            Console.WriteLine("not a palindrome");
        }

        Console.Write("Enter a number: ");
        int reminder = int.Parse(Console.ReadLine());
        Console.WriteLine(checkPalindrome.NFactorial(reminder));
        Console.Write("Enter a string: ");
        string newString = Console.ReadLine();
        string duplicateString = string.Empty;
        for (int i = 0; newString.Length > i; i++)
        {
            if (!duplicateString.Contains(newString[i]))
            {
                duplicateString += newString[i];
            }
        }
        Console.WriteLine(duplicateString);

        // Console.Write("Enter a int: ");
        //int newNumber = int.Parse(Console.ReadLine());
        int n = 1253;
        int tempVar = n;
        string number = n.ToString();
        int count = number.Length;
        double sum = 0;
        //Console.WriteLine(number);
        while (n > 0)
        {

            int numbers = n % 10;
            sum = sum + (Math.Pow(numbers, count));
            n = n / 10;
        }
        if (tempVar == sum)
        {

            Console.WriteLine(sum + "is armstrong");
        }
        else
        {
            Console.WriteLine("not armstrong");
        }
        /*int duplicateNum = newNumber;
        long sum = 0;
        CheckPalindrome checkPalindrome = new CheckPalindrome();
        while (newNumber > 0)
        {
           
             sum = sum + checkPalindrome.NFactorial(newNumber %10);
                newNumber = newNumber / 10;
            
            
        }
        if (sum == duplicateNum)
        {

            Console.WriteLine(duplicateNum + " is a strong num");
        }
        else
        {
            Console.WriteLine(duplicateNum + " is  not a strong num");
        }*/
        /* while (newNumber > 9)
         {
             int sum = 0;
             while (newNumber > 0)
             {
                 sum = sum + newNumber % 10;
                 newNumber = newNumber / 10;
             }
             newNumber = sum;
         }*/
        //Console.WriteLine(newNumber);

        //CalculatorProgram calculatorProgram = new CalculatorProgram();
        //Console.WriteLine("Enter 2 numbers");
        //Console.ReadLine();

        int[] newArray = new int[3];

        /*newArray[0] = 20;
        newArray[1] = 30;
        newArray[2] = 50;*/
        for (int i = 0; i < newArray.Length; i++)
        {
            //newArray[i] = i;
            Console.WriteLine(newArray[i]);

        }

        /*int[] newArray2 = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };
        Array.Reverse(newArray2);
        //Console.WriteLine(newArray2);
        for (int i = 0; i < newArray2.Length; i++)
        {
            Console.WriteLine(newArray2[i]);
        }

        int[] newArray3 = new int[10];
        Array.Copy(newArray2, newArray3, 5);
        foreach (int i in newArray3)
        {
            Console.WriteLine(newArray3[i]);
        }
        newArray3.GetLength(0);*/

        int[,] dimenArray = new int[3, 4]
        {
            { 2,3,4,3 },
            { 5,6,3,7},
            { 6,7,4,7},

        };
        for (int i = 0; i <= 3; i++)
        {

            for (int j = 0; j < 4; j++)
            {
                //Console.WriteLine(dimenArray[i, j]);
            }


        }
        foreach (int i in dimenArray)
        {
            Console.WriteLine(i + "");

        }
        int someNum = 123;
        int sum2 = 0;
        while (someNum > 0)
        {
            sum2 = sum2 * 10 + someNum % 10;
            someNum = someNum / 10;
        }
        Console.WriteLine(sum2);
    }
}
