using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string textNumber = Console.ReadLine();

            while (textNumber != "end")
            {
                int number = Convert.ToInt32(textNumber);
                int firstDigit = GetFirstDigit(number);
                number = Convert.ToInt32(textNumber);

                nums.Insert(firstDigit, number);

                textNumber = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        static int GetFirstDigit(int number)
        {
            int firstDigit = 0;
            while (number != 0)
            {
                firstDigit = number;
                number /= 10;
            }

            return firstDigit;
        }
    }
}
