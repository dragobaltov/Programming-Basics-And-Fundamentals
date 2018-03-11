using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers0To1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] digits = {"zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine"};
            string[] tens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen",
             "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] rounds = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if(number < 0 || number>100)
            {
                Console.WriteLine("invalid number");
            }
            else if(number>=0 && number<=9)
            {
                Console.WriteLine("{0}", digits[number]);
            }
            else if (number >= 10 && number <= 19)
            {
                Console.WriteLine("{0}", tens[number-10]);
            }
        }
    }
}
