using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP
{
    internal class CheckPalindrome
    {
        public bool IsPalindrome(string str, int first, int last)
        {
            if (first >= last)
                return true;

            if (str[first] != str[last])

                return false;

            return IsPalindrome(str, first + 1, last - 1);
        }

        public long NFactorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            return number * NFactorial(number - 1);
        }
    }
}
