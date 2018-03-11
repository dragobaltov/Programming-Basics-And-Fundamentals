using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsWithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            switch (number)
            {
                case "zero":
                    Console.WriteLine(arr[0]);
                    break;
                case "one":
                    Console.WriteLine(arr[1]);
                    break;
                case "two":
                    Console.WriteLine(arr[2]);
                    break;
                case "three":
                    Console.WriteLine(arr[3]);
                    break;
                case "four":
                    Console.WriteLine(arr[4]);
                    break;
                case "five":
                    Console.WriteLine(arr[5]);
                    break;
                case "six":
                    Console.WriteLine(arr[6]);
                    break;
                case "seven":
                    Console.WriteLine(arr[7]);
                    break;
                case "eight":
                    Console.WriteLine(arr[8]);
                    break;
                case "nine":
                    Console.WriteLine(arr[9]);
                    break;
                default:
                    break;
            }
        }
    }
}
