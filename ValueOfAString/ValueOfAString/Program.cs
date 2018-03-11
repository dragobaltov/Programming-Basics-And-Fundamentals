using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ValueOfAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string wantedCase = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (ItIsLetter(input[i]))
                {
                    if (ItIsInTheRightCase(wantedCase, input[i]))
                        sum += Convert.ToInt16(input[i]);
                }
            }

            Console.WriteLine($"The total sum is: {sum}");
        }

        static bool ItIsLetter(char symbol)
        {
            if ((symbol >= 'A' && symbol <= 'Z') || (symbol >= 'a' && symbol <= 'z'))
                return true;
            else
                return false;
        }

        static bool ItIsInTheRightCase(string rightCase, char letter)
        {
            if (rightCase == "UPPERCASE" && letter >= 'A' && letter <= 'Z')
                return true;
            else if (rightCase == "LOWERCASE" && letter >= 'a' && letter <= 'z')
                return true;
            else
                return false;
        }
    }
}
