using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP
{
    class LamdaFunctions
    {
        public void DivisibleBy()
        {
            List<int> numbers = new List<int> { 36, 12, 15, 18, 27, 9 };
            var square = numbers.FindAll(x => (x % 3) == 0);
            foreach(var value in square)
            {
                Console.WriteLine("{0}", value);
            }
        }

        public int rollNumber
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
    }
}
