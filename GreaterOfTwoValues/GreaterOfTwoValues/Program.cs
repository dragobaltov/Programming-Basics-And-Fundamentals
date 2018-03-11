using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(num1, num2));
            }
            else if (type == "char")
            {
                char ch1 = char.Parse(Console.ReadLine());
                char ch2 = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(ch1, ch2));
            }
            else if (type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();

                Console.WriteLine(GetMax(str1, str2));
            }
        }

        static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }

        static char GetMax(char ch1, char ch2)
        {
            if (ch1 > ch2)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
        }

        static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
    }
}
