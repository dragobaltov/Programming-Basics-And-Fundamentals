using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimeter
{
    class Program
    {
        static string[] array;
        static int countOfLetters;

        static void Main(string[] args)
        {
            array = Console.ReadLine().Split(' ').ToArray();
            countOfLetters = CountOfLettersInArray();
            int sumOfCharacters = AverageCharacter();
            double asciiCodeOfAverageDelimeter = Math.Floor(sumOfCharacters * 1.0 / countOfLetters);
            if (asciiCodeOfAverageDelimeter >= 97 && asciiCodeOfAverageDelimeter <= 122)
            {
                asciiCodeOfAverageDelimeter -= 32; 
            }
            int aCOfAD = Convert.ToInt32(asciiCodeOfAverageDelimeter);
            char averageDelimeter = Convert.ToChar(aCOfAD);
            string aD = Convert.ToString(averageDelimeter);

            Console.WriteLine(string.Join(aD, array));
        }

        static int AverageCharacter()
        {
            int sum = 0;
            foreach (string word in array)
            {
                foreach (char letter in word)
                {
                    int asciiCode = Convert.ToInt32(letter);
                    sum += asciiCode;
                }
            }

            return sum;
        }

        static int CountOfLettersInArray()
        {
            int countOfLetters = 0;
            foreach (string word in array)
            {
                foreach (char letter in word)
                {
                    countOfLetters++;
                }
            }

            return countOfLetters;
        }
    }
}
