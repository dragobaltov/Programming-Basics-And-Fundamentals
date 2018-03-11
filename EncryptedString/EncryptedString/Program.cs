using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            EncryptedString(n);
        }

        static void EncryptedString(int n)
        {
            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                Console.Write(GetCode(ch));
            }
        }

        static string GetCode(char ch)
        {
            int asciiCode = Convert.ToInt32(ch);
            int lastDigit = asciiCode % 10;
            int firstDigit = 0;
            char firstLetter = Convert.ToChar(asciiCode + lastDigit);

            while (asciiCode != 0)
            {
                firstDigit = asciiCode % 10;
                asciiCode /= 10;
            }
            asciiCode = Convert.ToInt32(ch);
            int smt = asciiCode - firstDigit;
            char lastLetter = Convert.ToChar(smt);
            string digits = Convert.ToString(firstDigit) + Convert.ToString(lastDigit);

            return firstLetter + digits + lastLetter;
        }
    }
}
