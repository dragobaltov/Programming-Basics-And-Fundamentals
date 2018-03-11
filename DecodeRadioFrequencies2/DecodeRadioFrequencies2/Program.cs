using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frequencies = Console.ReadLine().Split(' ');
            List<char> firstPart = new List<char>();
            List<char> secondPart = new List<char>();
            List<char> resultList = new List<char>();

            for (int i = 0; i < frequencies.Length; i++)
            {
                string[] numbers = frequencies[i].Split('.');
                int firstNum = int.Parse(numbers[0]);
                int secondNum = int.Parse(numbers[1]);
                char firstLetter = (char)firstNum;
                char secondLetter = (char)secondNum;

                if (firstNum != 0)
                    firstPart.Add(firstLetter);
                if (secondNum != 0)
                    secondPart.Add(secondLetter);
            }

            for (int i = 0; i < firstPart.Count; i++)
            {
                resultList.Add(firstPart[i]);
            }
            for (int i = secondPart.Count - 1; i >= 0; i--)
            {
                resultList.Add(secondPart[i]);
            }

            Console.WriteLine(string.Join("", resultList));
        }
    }
}
