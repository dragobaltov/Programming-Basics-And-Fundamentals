using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string strForRepeating = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatedString(strForRepeating, count));
        }

        static string RepeatedString(string str, int count)
        {
            string repeatedString = String.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }

            return repeatedString;
        }
    }
}
