using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
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
            string encryptedString = String.Empty;
       
            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                encryptedString = GetEncryptedString(ch);
                Console.Write(encryptedString);
            }
        }
       
        static string GetEncryptedString(char ch)
        {
            int firstDigit = 0;
            int lastDigit = 0;
            int asciiCode = Convert.ToInt16(ch);
       
            lastDigit = asciiCode % 10;
            char firstLetter = Convert.ToChar(asciiCode + lastDigit);
       
            while (asciiCode != 0)
            {
                firstDigit = asciiCode % 10;
                asciiCode /= 10;
            }
            
            string digits = Convert.ToString(firstDigit) + Convert.ToString(lastDigit);
            return firstLetter + digits;
        }

        
    }
}
